// ts2fable 0.8.0
module rec Fable.Import.Msal.ClientInfo
open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract ClientInfo: ClientInfoStatic

type [<AllowNullLiteral>] ClientInfo =
    abstract uid: string with get, set
    abstract utid: string with get, set

type [<AllowNullLiteral>] ClientInfoStatic =
    [<Emit "new $0($1...)">] abstract Create: rawClientInfo: string -> ClientInfo



