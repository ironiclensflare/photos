
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using Photos.Models;

namespace Photos
{
    public static class CreatePhoto
    {
        [FunctionName("CreatePhoto")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequest req, TraceWriter log)
        {
            var requestBody = new StreamReader(req.Body).ReadToEnd();
            var photo = JsonConvert.DeserializeObject<Photo>(requestBody);
            return new OkObjectResult(photo);
        }
    }
}
