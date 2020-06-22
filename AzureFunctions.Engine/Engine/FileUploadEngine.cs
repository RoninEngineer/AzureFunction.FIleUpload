using AzureFunction.Engine.Attributes;
using AzureFunction.Engine.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace AzureFunction.Engine.Engine
{
    public class FileUploadEngine : IFileUploadEngine
    {
        public async Task<bool> IsMultipartContent(HttpRequest request)
        {
            try
            {
                var isMultipart = await Task.Run(() => MultipartRequest.IsMultipartContentType(request.ContentType));
                if (!isMultipart)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
