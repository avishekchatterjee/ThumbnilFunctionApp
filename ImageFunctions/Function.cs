using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ImageFunctions
{
    public static class Function
    {
        [FunctionName("Function")]
        public static void Run([BlobTrigger("Path/{name}", Connection = "ConnectionStrings:inspiceimagestorageconn")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
