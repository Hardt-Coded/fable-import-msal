## Fable Import for MSAL - Microsoft Authentication Library

https://github.com/AzureAD/microsoft-authentication-library-for-js

### Usage:

1. add this package to you project. Ether use `paket` oder `nuget` directly.

2. add the msal package with npm

   ```
   npm install msal 
   ```

3. Build up some configuration for example:

    ```fsharp
        let private msalConfig () :Msal.Configuration.Configuration =
            let authSettings:Msal.Configuration.AuthOptions =
                !!{|
                    clientId = "[your client Id]"
                    navigateToLoginRequestUrl = Some true
                    redirectUri = (Some window.location.origin)
                    postLogoutRedirectUri = (Some window.location.origin)
                    authority = Some "https://login.microsoftonline.com/[your tanentid]"
                |}
    
            let cacheSettings:Msal.Configuration.CacheOptions =
                !!{|
                    cacheLocation = Some Msal.Configuration.CacheLocation.LocalStorage
                |}
    
            let config:Msal.Configuration.Configuration =
                !!{| 
                    auth=authSettings
                    cache=Some cacheSettings
                |}
            
            config
    ```

4. Create a User Agent

    ```fsharp
        let userAgent =
            let config = msalConfig ()
            Msal.UserAgentApplication.userAgentApplication.Create(config)
    ```

5. Create a little helper function for the auth parameters. They are needed in different shapes later. In this example, I need later access to the management api. Please be aware, that the scopes are mostly uri's. Only for the graph-api they are implicit. like openid etc. pp.

    ```fsharp
        let getAuthenticationParameters (account:Msal.Account.Account option) : Msal.AuthenticationParameters.AuthenticationParameters =
            !!{|
                redirectUri = (Some window.location.origin)
                account = account
                scopes = [| "https://management.azure.com//user_impersonation"|]
            |}
    ```

6. Your App must call, if you use redirect as login following command:

    ```fsharp
        let tokenRecievedCallback (authErr:Msal.AuthError.AuthError) (response:Msal.AuthResponse.AuthResponse) =
            ()

        userAgent.handleRedirectCallback tokenRecievedCallback
    ```

7. You can check, if you are logged in by:

    ```fsharp
        let account = userAgent.getAccount()
        if (account <> null) then
            // do when you are cogged in
        else
            // do things, when you are not
    ```



8. To Login with redirect. Call:


    ```fsharp
        let authParameters = getAuthenticationParameters(None)
        userAgent.loginRedirect(authParameters)
    ```

9. You have to be aware, that `userAgent.handleRedirectCallback` has to be called before you try to login.

10. here is a little async helper (I will put this late in this package) to aquire a token silently. Do it before you call some api. If you have already a token, that it will use you cache.

    ```fsharp
        let aquireToken userRequest =
            Async.FromContinuations <| fun (resolve, reject, _) ->
                userAgent.acquireTokenSilent(userRequest)
                    .``then``(
                        fun response ->
                            resolve response
                    )
                    .catch(fun (error) ->
                        console.log(error)
                        let ex = exn (error?errorMessage)
                        reject ex
                    )
                |> ignore
    ```

    So you call call something like:
    ```fsharp
        let callSomeFancyApi () =
            async {
                try
                    let account = userAgent.getAccount()
                    if (account = null) then
                        return Error "account missing, user maybe not logged in."
                    else
                        let authParams = Authorization.getAuthenticationParameters(Some account)
                        let! authResponse = Authorization.aquireToken(authParams)
                        
                        let! result = getFancyResponseFromFancyApiAsync authResponse.accessToken
                        
                        return result
                with
                | _ as ex -> 
                    return Error ex.Message
            }
    ```


Feel free to contact me


