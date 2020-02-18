// ts2fable 0.8.0
module rec Fable.Import.Msal.AuthResponse
open System
open Fable.Core
open Fable.Core.JS

type Array<'T> = System.Collections.Generic.IList<'T>

type Account = Account.Account
type IdToken = IdToken.IdToken
type StringDict = MsalTypes.StringDict

type [<AllowNullLiteral>] IExports =
    abstract buildResponseStateOnly: state: string -> AuthResponse

type [<AllowNullLiteral>] AuthResponse =
    abstract uniqueId: string with get, set
    abstract tenantId: string with get, set
    abstract tokenType: string with get, set
    abstract idToken: IdToken with get, set
    abstract idTokenClaims: StringDict with get, set
    abstract accessToken: string with get, set
    abstract scopes: Array<string> with get, set
    abstract expiresOn: DateTime with get, set
    abstract account: Account with get, set
    abstract accountState: string with get, set
    abstract fromCache: bool with get, set




