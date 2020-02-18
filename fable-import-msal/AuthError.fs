// ts2fable 0.8.0
module rec Fable.Import.Msal.AuthError
open System
open Fable.Core
open Fable.Core.JS


type Error = System.Exception

let [<Import("AuthErrorMessage","module")>] AuthErrorMessage: AuthErrorMessage = jsNative

type [<AllowNullLiteral>] IExports =
    abstract AuthError: AuthErrorStatic

/// General error class thrown by the MSAL.js library.
type [<AllowNullLiteral>] [<AbstractClass>] AuthError() =
    inherit Error()
    abstract errorCode: string with get, set
    abstract errorMessage: string with get, set

/// General error class thrown by the MSAL.js library.
type [<AllowNullLiteral>] AuthErrorStatic =
    [<Emit "new $0($1...)">] abstract Create: errorCode: string * ?errorMessage: string -> AuthError
    abstract createUnexpectedError: errDesc: string -> AuthError
    abstract createNoWindowObjectError: errDesc: string -> AuthError

type [<AllowNullLiteral>] AuthErrorMessageUnexpectedError =
    abstract code: string with get, set
    abstract desc: string with get, set

type [<AllowNullLiteral>] AuthErrorMessage =
    abstract unexpectedError: AuthErrorMessageUnexpectedError with get, set
    abstract noWindowObjectError: AuthErrorMessageUnexpectedError with get, set



