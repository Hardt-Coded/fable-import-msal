// ts2fable 0.8.0
module rec Fable.Import.Msal.TelemetryEvent
open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract TelemetryEvent: TelemetryEventStatic

type [<AllowNullLiteral>] TelemetryEvent =
    abstract ``event``: obj option with get, set
    abstract eventId: string with get, set
    abstract stop: unit -> unit
    abstract telemetryCorrelationId: string with get, set
    abstract eventName: string
    abstract get: unit -> obj

type [<AllowNullLiteral>] TelemetryEventStatic =
    [<Emit "new $0($1...)">] abstract Create: eventName: string * correlationId: string -> TelemetryEvent



