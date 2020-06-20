using AzureFunction.Engine.Engine;
using AzureFunction.Engine.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctions.Engine
{
    public static class EngineConfiguration
    {
        public static void ConfigureEngine(this IServiceCollection services)
        {
            services.AddSingleton<IFileUploadEngine, FileUploadEngine>();
        }
    }
}
