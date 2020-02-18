// ts2fable 0.8.0
module rec Fable.Import.Msal.AccessTokenCacheItem
open System
open Fable.Core
open Fable.Core.JS

type AccessTokenKey = AccessTokenKey.AccessTokenKey
type AccessTokenValue = AccessTokenValue.AccessTokenValue

type [<AllowNullLiteral>] IExports =
    abstract AccessTokenCacheItem: AccessTokenCacheItemStatic

type [<AllowNullLiteral>] AccessTokenCacheItem =
    abstract key: AccessTokenKey with get, set
    abstract value: AccessTokenValue with get, set

type [<AllowNullLiteral>] AccessTokenCacheItemStatic =
    [<Emit "new $0($1...)">] abstract Create: key: AccessTokenKey * value: AccessTokenValue -> AccessTokenCacheItem



