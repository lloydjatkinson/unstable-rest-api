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
        [FunctionName("lorem")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequest req, ILogger log)
        {
            await RandomDelayHelper.DelayRandomly(3);

            log.LogInformation($"{nameof(LoremIpsum)} function triggered.");

            return ResponseFactory.LoremIpsum(10);

            //string name = req.Query["name"];

            //string requestBody = new StreamReader(req.Body).ReadToEnd();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            //return name != null
            //    ? (ActionResult)new OkObjectResult($"Hello, {name}")
            //    : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}