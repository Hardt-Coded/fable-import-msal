// ts2fable 0.8.0
module rec Fable.Import.Msal.IUri
open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IUri =
    abstract Protocol: string with get, set
    abstract HostNameAndPort: string with get, set
    abstract AbsolutePath: string with get, set
    abstract Search: string with get, set
    abstract Hash: string with get, set
    abstract PathSegments: ResizeArray<string> with get, set


