using AzureFunction.Engine.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Web.Http;
using System;

namespace AzureFunction_FileUpload_ToDB
{
    public class FileUpload
    {
        private readonly IFileUploadEngine _fileUploadEngine;
        public FileUpload(IFileUploadEngine engine)
        {
            _fileUploadEngine = engine;
        }

        [FunctionName("FileUpload")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req, ILogger log)
        {
            try
            {
                var response = await _fileUploadEngine.IsMultipartContent(req);
                if (response)
                {
                    
                }
                return (ActionResult)new OkObjectResult(response);
            }
            catch (Exception)
            {

                return (ActionResult)new InternalServerErrorResult();
            }
            

           
        }
    }
}
