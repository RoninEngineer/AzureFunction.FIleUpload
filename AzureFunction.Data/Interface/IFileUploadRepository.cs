using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;
using System.Threading.Tasks;

namespace AzureFunction.Data.Interface
{
    public interface IFileUploadRepository
    {
        Task<MultipartReader> GetMultipartReader(HttpRequest request);
    }
}
