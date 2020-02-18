// ts2fable 0.8.0
module rec Fable.Import.Msal.Account
open System
open Fable.Core
open Fable.Core.JS

type ClientInfo = ClientInfo.ClientInfo
type IdToken = IdToken.IdToken
type StringDict = MsalTypes.StringDict

type [<AllowNullLiteral>] IExports =
    abstract Account: AccountStatic

/// accountIdentifier       combination of idToken.uid and idToken.utid
/// homeAccountIdentifier   combination of clientInfo.uid and clientInfo.utid
/// userName                idToken.preferred_username
/// name                    idToken.name
/// idToken                 idToken
/// sid                     idToken.sid - session identifier
/// environment             idtoken.issuer (the authority that issues the token)
type [<AllowNullLiteral>] Account =
    abstract accountIdentifier: string with get, set
    abstract homeAccountIdentifier: string with get, set
    abstract userName: string with get, set
    abstract name: string with get, set
    abstract idToken: StringDict with get, set
    abstract idTokenClaims: StringDict with get, set
    abstract sid: string with get, set
    abstract environment: string with get, set

/// accountIdentifier       combination of idToken.uid and idToken.utid
/// homeAccountIdentifier   combination of clientInfo.uid and clientInfo.utid
/// userName                idToken.preferred_username
/// name                    idToken.name
/// idToken                 idToken
/// sid                     idToken.sid - session identifier
/// environment             idtoken.issuer (the authority that issues the token)
type [<AllowNullLiteral>] AccountStatic =
    /// Creates an Account Object
    [<Emit "new $0($1...)">] abstract Create: accountIdentifier: string * homeAccountIdentifier: string * userName: string * name: string * idTokenClaims: StringDict * sid: string * environment: string -> Account
    abstract createAccount: idToken: IdToken * clientInfo: ClientInfo -> Account
    /// <summary>Utils function to compare two Account objects - used to check if the same user account is logged in</summary>
    /// <param name="a1">: Account object</param>
    /// <param name="a2">: Account object</param>
    abstract compareAccounts: a1: Account * a2: Account -> bool



