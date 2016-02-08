namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("px")>]
[<assembly: AssemblyProductAttribute("px")>]
[<assembly: AssemblyDescriptionAttribute("px")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
