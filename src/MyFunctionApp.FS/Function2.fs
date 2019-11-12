namespace MyFunctionApp.FS

open System
open Microsoft.Azure.WebJobs
open Microsoft.Extensions.Logging

module Function2 =
    [<FunctionName("Function2")>]
    let run ([<TimerTrigger("0 */5 * * * *")>]myTimer:TimerInfo, log:ILogger) =
        log.LogInformation("F# Timer trigger function executed at:" + DateTime.Now.ToString())
