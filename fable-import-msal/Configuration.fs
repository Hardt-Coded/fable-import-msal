// ts2fable 0.8.0
module rec Fable.Import.Msal.Configuration
open System
open Fable.Core
open Fable.Core.JS

type Array<'T> = System.Collections.Generic.IList<'T>

type Logger = Logger.Logger
type TelemetryEmitter = TelemetryTypes.TelemetryEmitter

type [<AllowNullLiteral>] IExports =
    /// MSAL function that sets the default options when not explicitly configured from app developer
    abstract buildConfiguration: p0: Configuration -> Configuration

type [<StringEnum>] [<RequireQualifiedAccess>] CacheLocation =
    | LocalStorage
    | SessionStorage

type [<AllowNullLiteral>] AuthOptions =
    abstract clientId: string with get, set
    abstract authority: string option with get, set
    abstract validateAuthority: bool option with get, set
    //abstract redirectUri: U2<string, (unit -> string)> option with get, set
    abstract redirectUri: string option with get, set
    //abstract postLogoutRedirectUri: U2<string, (unit -> string)> option with get, set
    abstract postLogoutRedirectUri: string option with get, set
    abstract navigateToLoginRequestUrl: bool option with get, set

type [<AllowNullLiteral>] CacheOptions =
    abstract cacheLocation: CacheLocation option with get, set
    abstract storeAuthStateInCookie: bool option with get, set

type [<AllowNullLiteral>] TelemetryOptions =
    abstract applicationName: string with get, set
    abstract applicationVersion: string with get, set
    abstract telemetryEmitter: TelemetryEmitter with get, set

type [<AllowNullLiteral>] SystemOptions =
    abstract logger: Logger option with get, set
    abstract loadFrameTimeout: float option with get, set
    abstract tokenRenewalOffsetSeconds: float option with get, set
    abstract navigateFrameWait: float option with get, set
    abstract telemetry: TelemetryOptions option with get, set

type [<AllowNullLiteral>] FrameworkOptions =
    abstract isAngular: bool option with get, set
    abstract unprotectedResources: Array<string> option with get, set
    abstract protectedResourceMap: Map<string, Array<string>> option with get, set

type [<AllowNullLiteral>] Configuration =
    abstract auth: AuthOptions with get, set
    abstract cache: CacheOptions option with get, set
    abstract system: SystemOptions option with get, set
    abstract framework: FrameworkOptions option with get, set




