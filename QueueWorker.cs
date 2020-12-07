using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace twelvefactor
{
    public static class QueueWorker
    {
        [FunctionName("QueueWorker")]
        public static void Run([QueueTrigger("12factorqueue", Connection = "12factorserverless_STORAGE")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
