// ts2fable 0.8.0
module rec Fable.Import.Msal.AuthenticationParameters
open System
open Fable.Core
open Fable.Core.JS

type Array<'T> = System.Collections.Generic.IList<'T>

type Account = Account.Account
type StringDict = MsalTypes.StringDict

type [<AllowNullLiteral>] IExports =
    abstract validateClaimsRequest: request: AuthenticationParameters -> unit

type [<AllowNullLiteral>] AuthenticationParameters =
    abstract scopes: string[] with get, set
    abstract extraScopesToConsent: string[] with get, set
    abstract prompt: string option with get, set
    abstract extraQueryParameters: StringDict option with get, set
    abstract claimsRequest: string option with get, set
    abstract authority: string option with get, set
    abstract state: string option with get, set
    abstract correlationId: string option with get, set
    abstract account: Account option with get, set
    abstract sid: string option with get, set
    abstract loginHint: string option with get, set
    abstract forceRefresh: bool option with get, set
    abstract redirectUri: string option with get, set



