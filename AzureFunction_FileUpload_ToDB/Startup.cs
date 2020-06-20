using AzureFunction.Data;
using AzureFunction_FileUpload_ToDB;
using AzureFunctions.Engine;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]

namespace AzureFunction_FileUpload_ToDB
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.ConfigureData();
            builder.Services.ConfigureEngine();
        }
    }
}
