using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

using UnstableRestApi.Services;

namespace UnstableRestApi
{
    public static class LoremIpsum
    {
        [FunctionName("loremipsum")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequest req, ILogger log)
        {
            log.LogInformation($"{nameof(LoremIpsum)} function triggered.");
            await RandomDelayHelper.DelayRandomly(3);


            return ResponseFactory.LoremIpsum(10);
        }
    }
}