﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp.Data.Toolbox.Sas")>]
[<assembly: AssemblyProductAttribute("FSharp.Data.Toolbox")>]
[<assembly: AssemblyDescriptionAttribute("F# Data-based library for various data access APIs.")>]
[<assembly: AssemblyVersionAttribute("0.15")>]
[<assembly: AssemblyFileVersionAttribute("0.15")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.15"
    let [<Literal>] InformationalVersion = "0.15"
