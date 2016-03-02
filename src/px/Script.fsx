// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

//#load "Library.fs"
//#r "C:\ws\px\packages\SQLProvider\lib\FSharp.Data.SqlProvider.dll"
//open px
//open System
//open System.Linq
//open FSharp.Data.Sql
//
//type sql = SqlDataProvider<
//                ConnectionString = 



//
//let num = Library.hello 24
//printfn "%i" num


//#I __SOURCE_DIRECTORY__
//#r @"../../packages/SQLProvider/lib/FSharp.Data.SqlProvider.dll"
//
//open System
//open FSharp.Data.Sql
//open System.Data
//
//[<Literal>]
//let connStr = "server=apl03.opgi.com;port=5432;user id=postgres;password=postgres;database=postgres;commandtimeout=5000"
////let connStr = "User ID=apl-postgre;Host=localhost;Port=5432;Database=sqlprovider;"
//
//[<Literal>]
//let resolutionFolder = @"..\..\..\packages\Scripts\Npgsql\lib\net45"
//        
//FSharp.Data.Sql.Common.QueryEvents.SqlQueryEvent |> Event.add (printfn "Executing SQL: %s")
//FSharp.Data.Sql.Common.QueryEvents.LinqExpressionEvent |> Event.add (printfn "Expression: %A")
//
//let processId = System.Diagnostics.Process.GetCurrentProcess().Id;
//
//type db = SqlDataProvider<
//                Common.DatabaseProviderTypes.POSTGRESQL, 
//                connStr, ResolutionPath = resolutionFolder , 
//                UseOptionTypes=true>
//let ctx = db.GetDataContext()



(*** hide ***)
//#I @"../../files/sqlite"
(*** hide ***)
//#I "../../../bin"
(*** hide ***)

(*** hide ***)
//[<Literal>]
//let resolutionPath =
//    __SOURCE_DIRECTORY__ + @"..\..\..\packages\Scripts\Npgsql\lib\net45"
#r "../../packages/SQLProvider/lib/FSharp.Data.SqlProvider.dll"
open FSharp.Data.Sql    
(**
# PostgreSQL Provider
## Parameters
### ConnectionString
Basic connection string used to connect to PostgreSQL instance; typical 
connection strings for the driver apply here. See
(PostgreSQL Connecting Strings Documentation)[https://github.com/npgsql/Npgsql/wiki/User-Manual]
for a complete list of connection string options.
*)

//let connString = "Server=localhost;Database=test;User Id=test;Password=test"

(**
### ConnectionStringName
Instead of storing the connection string in the source code / `fsx` script, you
can store values in the `App.config` file.  This is the name of the
connectionString key/value pair stored in App.config (TODO: confirm file name).
*)

// found in App.config (TOOD: confirm)
let connexStringName = "DefaultConnectionString"

(**
### DatabaseVendor
From the `FSharp.Data.Sql.Common.DatabaseProviderTypes` enumeration. For PostgreSQL,
use `Common.DatabaseProviderTypes.POSTGRESQL`.
*)

let dbVendor = Common.DatabaseProviderTypes.POSTGRESQL

(**
### Resolution Path
Path to search for assemblies containing database vendor specific connections 
and custom types. Type the path where `Npgsql.Data.dll` is stored.
*)

let resPath = @"C:\ws\_libs\"

(**
### IndividualsAmount
Sets the count to load for each individual. See (individuals)[individuals.html] 
for further info.
*)

let indivAmount = 1000

(**
### UseOptionTypes
If true, F# option types will be used in place of nullable database columns.  
If false, you will always receive the default value of the column's type even 
if it is null in the database.
*)

let useOptTypes  = true

//let sql             = SqlDataProvider<
//                        connsString,
//                        dbVendor,
//                        resPath,
//                        indivAmount,
//                        useOptTypes
//                      >
//
//type db = SqlDataProvider<
//                Common.DatabaseProviderTypes.POSTGRESQL,
//                @"server=apl03.opgi.com;port=5432;user id=postgres;password=postgres;database=postgres;commandtimeout=5000",
//                @"..\..\..\packages\Scripts\Npgsql\lib\net45",
//                UseOptionTypes=true>
//let ctx = db.GetDataContext()   

