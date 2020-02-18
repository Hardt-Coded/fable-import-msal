// ts2fable 0.8.0
module rec Fable.Import.Msal.AccessTokenValue
open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract AccessTokenValue: AccessTokenValueStatic

type [<AllowNullLiteral>] AccessTokenValue =
    abstract accessToken: string with get, set
    abstract idToken: string with get, set
    abstract expiresIn: string with get, set
    abstract homeAccountIdentifier: string with get, set

type [<AllowNullLiteral>] AccessTokenValueStatic =
    [<Emit "new $0($1...)">] abstract Create: accessToken: string * idToken: string * expiresIn: string * homeAccountIdentifier: string -> AccessTokenValue



