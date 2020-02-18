// ts2fable 0.8.0
module rec Fable.Import.Msal.AccessTokenKey
open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract AccessTokenKey: AccessTokenKeyStatic

type [<AllowNullLiteral>] AccessTokenKey =
    abstract authority: string with get, set
    abstract clientId: string with get, set
    abstract scopes: string with get, set
    abstract homeAccountIdentifier: string with get, set

type [<AllowNullLiteral>] AccessTokenKeyStatic =
    [<Emit "new $0($1...)">] abstract Create: authority: string * clientId: string * scopes: string * uid: string * utid: string -> AccessTokenKey



