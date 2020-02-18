// ts2fable 0.8.0
module rec Fable.Import.Msal.Logger
open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract Logger: LoggerStatic

type [<AllowNullLiteral>] ILoggerCallback =
    [<Emit "$0($1...)">] abstract Invoke: level: LogLevel * message: string * containsPii: bool -> unit

type [<RequireQualifiedAccess>] LogLevel =
    | Error = 0
    | Warning = 1
    | Info = 2
    | Verbose = 3

type [<AllowNullLiteral>] Logger =
    abstract executeCallback: level: LogLevel * message: string * containsPii: bool -> unit
    abstract error: message: string -> unit
    abstract errorPii: message: string -> unit
    abstract warning: message: string -> unit
    abstract warningPii: message: string -> unit
    abstract info: message: string -> unit
    abstract infoPii: message: string -> unit
    abstract verbose: message: string -> unit
    abstract verbosePii: message: string -> unit
    abstract isPiiLoggingEnabled: unit -> bool

type [<AllowNullLiteral>] LoggerStatic =
    [<Emit "new $0($1...)">] abstract Create: localCallback: ILoggerCallback * ?options: LoggerStaticOptions -> Logger

type [<AllowNullLiteral>] LoggerStaticOptions =
    abstract correlationId: string option with get, set
    abstract level: LogLevel option with get, set
    abstract piiLoggingEnabled: bool option with get, set



