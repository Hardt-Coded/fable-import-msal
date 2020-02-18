// ts2fable 0.8.0
module rec Fable.Import.Msal.Authority
open System
open Fable.Core
open Fable.Core.JS

type IUri = IUri.IUri

type [<AllowNullLiteral>] IExports =
    abstract Authority: AuthorityStatic

type [<RequireQualifiedAccess>] AuthorityType =
    | Aad = 0
    | Adfs = 1
    | B2C = 2

type [<AllowNullLiteral>] Authority =
    abstract AuthorityType: AuthorityType
    abstract IsValidationEnabled: bool with get, set
    abstract Tenant: string
    abstract AuthorizationEndpoint: string
    abstract EndSessionEndpoint: string
    abstract SelfSignedJwtAudience: string
    /// A URL that is the authority set by the developer
    abstract CanonicalAuthority: string with get, set
    abstract CanonicalAuthorityUrlComponents: IUri
    /// // http://openid.net/specs/openid-connect-discovery-1_0.html#ProviderMetadata
    abstract DefaultOpenIdConfigurationEndpoint: string
    /// Returns a promise.
    /// Checks to see if the authority is in the cache
    /// Discover endpoints via openid-configuration
    /// If successful, caches the endpoint for later use in OIDC
    abstract resolveEndpointsAsync: unit -> Promise<Authority>
    /// Returns a promise with the TenantDiscoveryEndpoint
    abstract GetOpenIdConfigurationEndpointAsync: unit -> Promise<string>

type [<AllowNullLiteral>] AuthorityStatic =
    [<Emit "new $0($1...)">] abstract Create: authority: string * validateAuthority: bool -> Authority



