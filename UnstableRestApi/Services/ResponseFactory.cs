using System;

using LoremNET;

using Microsoft.AspNetCore.Mvc;

using UnstableRestApi.Dto;

namespace UnstableRestApi
{
    public static class ResponseFactory
    {
        public static IActionResult LoremIpsum(int wordCount)
        {
            double random = new Random().NextDouble();
            IActionResult result;

            if (random < 0.6)
            {
                result = new JsonResult(new LoremIpsumResponse(Lorem.Words(wordCount)));
            }
            else if (random < 0.8)
            {
                result = new AcceptedResult();
            }
            else if (random < 0.95)
            {
                result = new BadRequestResult();
            }
            else
            {
                result = new StatusCodeResult(500);
            }

            return result;
        }
    }
}