﻿module FluentCastTest.``To GUID``
open System
open FsUnit
open NUnit.Framework
open FluentCast
open FluentCastTestConst

/// ===========================================
/// ToGuid
/// ===========================================
[<Test>]
let ``Convert String to Guid``() = StringGuidInput.ToGuid() |> should equal GuidExpected

[<Test>]
let ``Convert String Broken to Guid exception``() = (fun () -> StringBrokenInput.ToGuid() |> ignore) |> should throw typeof<FormatException>

/// ===========================================
/// ToGuidSafe
/// ===========================================
[<Test>]
let ``Convert String to Guid Safe``() = StringGuidInput.ToGuidSafe() |> should equal GuidExpected

[<Test>]
let ``Convert String Broken to Guid Safe``() = StringBrokenInput.ToGuidSafe() |> should be null