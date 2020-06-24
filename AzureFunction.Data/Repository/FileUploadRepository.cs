using AzureFunction.Data.Interface;
using AzureFunction.Engine.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Net.Http.Headers;
using System.Threading.Tasks;

namespace AzureFunction.Data.Repository
{
    public class FileUploadRepository : IFileUploadRepository
    {
        public async Task<MultipartReader> GetMultipartReader(HttpRequest request)
        {
            FormOptions _defaultFormOptions = new FormOptions();
            var boundary = await Task.Run(() => MultipartRequest.GetBoundary(MediaTypeHeaderValue.Parse(request.ContentType), _defaultFormOptions.MultipartBoundaryLengthLimit));
            var reader = new MultipartReader(boundary, request.Body);

            return reader;
        }
    }
}
