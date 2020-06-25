using AzureFunction.Data.Interface;
using AzureFunction.Engine.Attributes;
using AzureFunction.Engine.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Threading.Tasks;

namespace AzureFunction.Engine.Engine
{
    public class FileUploadEngine : IFileUploadEngine
    {
        private readonly IFileUploadRepository _fileImportRepo;

        public FileUploadEngine(IFileUploadRepository fileImportRepo)
        {
            _fileImportRepo = fileImportRepo;
        }

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

        public async Task<MultipartReader> ValidateImportDataRequest(HttpRequest request)
        {
            var reader = await _fileImportRepo.GetMultipartReader(request);
            return reader;
        }
    }
}
