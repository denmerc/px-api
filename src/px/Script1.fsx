#I @"../../bin"
#r @"../../packages/SQLProvider/lib/FSharp.Data.SqlProvider.dll"
open System
open FSharp.Data.Sql
open System.Data
open System.IO

[<Literal>]
let resolutionFolder = @"C:\ws\px\packages\Npgsql.3.0.5\lib\net45"


//let resolutionFolder = System.IO.Path.Combine(__SOURCE_DIRECTORY__ , @"packages/Npgsql.3.0.5/lib/net45")
//#if DEBUG
//    @../../packages/Npgsql/lib/net45"
//#else
//    @"../../packages/Npgsql.3.0.5/lib/net45"
//#endif

[<Literal>]
let connStr="server=apl03;port=5432;user id=postgres;password=postgres;database=postgres;commandtimeout=5000;pooling=false;"
//[<Literal>]
//let connStr = "User ID=colinbull;Host=localhost;Port=5432;Database=sqlprovider;"
let useOptTypes = true

[<Literal>]
let owner  = @"postgres' OR table_schema = 'PX_Main' or table_schema = 'PX_Stage' or table_schema = 'PX_Tracking''"

type sql = SqlDataProvider<Common.DatabaseProviderTypes.POSTGRESQL, connStr, ResolutionPath = resolutionFolder, 
                            UseOptionTypes=true, Owner=owner, 
                            CaseSensitivityChange=Common.CaseSensitivityChange.ORIGINAL>
//type sql = SqlDataProvider<Common.DatabaseProviderTypes.POSTGRESQL, connStr, ResolutionPath = resolutionFolder>

let ctx = sql.GetDataContext()



let employeesFirstNameIdProj = 
    query {
        for emp in ctx.PxMain.Analytic do
        select emp
    } |> Seq.toList


 

