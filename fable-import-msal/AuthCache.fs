// ts2fable 0.8.0
module rec Fable.Import.Msal.AuthCache
open System
open Fable.Core
open Fable.Core.JS

type Array<'T> = System.Collections.Generic.IList<'T>

type AccessTokenCacheItem = AccessTokenCacheItem.AccessTokenCacheItem
type CacheLocation = Configuration.CacheLocation
type BrowserStorage = BrowserStorage.BrowserStorage

type [<AllowNullLiteral>] IExports =
    abstract AuthCache: AuthCacheStatic

type [<AllowNullLiteral>] AuthCache =
    inherit BrowserStorage
    /// add value to storage
    abstract setItem: key: string * value: string * ?enableCookieStorage: bool * ?state: string -> unit
    /// get one item by key from storage
    abstract getItem: key: string * ?enableCookieStorage: bool -> string
    /// remove value from storage
    abstract removeItem: key: string -> unit
    /// Reset the cache items
    abstract resetCacheItems: unit -> unit
    /// Reset all temporary cache items
    abstract resetTempCacheItems: state: string -> unit
    /// Set cookies for IE
    abstract setItemCookie: cName: string * cValue: string * ?expires: float -> unit
    /// get one item by key from cookies
    abstract getItemCookie: cName: string -> string
    /// Get all access tokens in the cache
    abstract getAllAccessTokens: clientId: string * homeAccountIdentifier: string -> Array<AccessTokenCacheItem>
    /// Clear all cookies
    abstract clearMsalCookie: ?state: string -> unit

type [<AllowNullLiteral>] AuthCacheStatic =
    [<Emit "new $0($1...)">] abstract Create: clientId: string * cacheLocation: CacheLocation * storeAuthStateInCookie: bool -> AuthCache
    /// Create acquireTokenAccountKey to cache account object
    abstract generateAcquireTokenAccountKey: accountId: obj option * state: string -> string
    /// Create authorityKey to cache authority
    abstract generateAuthorityKey: state: string -> string



