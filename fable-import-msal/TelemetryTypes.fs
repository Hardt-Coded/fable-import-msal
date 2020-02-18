// ts2fable 0.8.0
module rec Fable.Import.Msal.TelemetryTypes
open System
open Fable.Core
open Fable.Core.JS
open Fable.Import.Msal.TelemetryEvent

type Array<'T> = System.Collections.Generic.IList<'T>


type [<AllowNullLiteral>] InProgressEvents =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> TelemetryEvent with get, set

type [<AllowNullLiteral>] EventCount =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: eventName: string -> float with get, set

type [<AllowNullLiteral>] EventCountByCorrelationId =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: correlationId: string -> EventCount with get, set

type [<AllowNullLiteral>] CompletedEvents =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: correlationId: string -> Array<TelemetryEvent> with get, set

type [<AllowNullLiteral>] TelemetryEmitter =
    [<Emit "$0($1...)">] abstract Invoke: events: Array<obj> -> unit

type [<AllowNullLiteral>] TelemetryPlatform =
    abstract sdk: string with get, set
    abstract sdkVersion: string with get, set
    abstract applicationName: string with get, set
    abstract applicationVersion: string with get, set

type [<AllowNullLiteral>] TelemetryConfig =
    abstract platform: TelemetryPlatform with get, set
    abstract onlySendFailureTelemetry: bool option with get, set
    abstract clientId: string with get, set



