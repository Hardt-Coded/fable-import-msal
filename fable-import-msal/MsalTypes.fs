// ts2fable 0.8.0
module rec Fable.Import.Msal.MsalTypes
open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] StringDict =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> string with get, set
