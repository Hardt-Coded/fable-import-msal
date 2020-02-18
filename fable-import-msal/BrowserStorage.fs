// ts2fable 0.8.0
module rec Fable.Import.Msal.BrowserStorage
open System
open Fable.Core
open Fable.Core.JS

type CacheLocation = Configuration.CacheLocation

type [<AllowNullLiteral>] IExports =
    abstract BrowserStorage: BrowserStorageStatic

type [<AllowNullLiteral>] BrowserStorage =
    abstract cacheLocation: CacheLocation with get, set
    /// add value to storage
    abstract setItem: key: string * value: string * ?enableCookieStorage: bool -> unit
    /// get one item by key from storage
    abstract getItem: key: string * ?enableCookieStorage: bool -> string
    /// remove value from storage
    abstract removeItem: key: string -> unit
    /// clear storage (remove all items from it)
    abstract clear: unit -> unit
    /// add value to cookies
    abstract setItemCookie: cName: string * cValue: string * ?expires: float -> unit
    /// get one item by key from cookies
    abstract getItemCookie: cName: string -> string
    /// Clear an item in the cookies by key
    abstract clearItemCookie: cName: string -> unit
    /// Get cookie expiration time
    abstract getCookieExpirationTime: cookieLifeDays: float -> string

type [<AllowNullLiteral>] BrowserStorageStatic =
    [<Emit "new $0($1...)">] abstract Create: cacheLocation: CacheLocation -> BrowserStorage



