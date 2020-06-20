using AzureFunction.Data.Factory;
using AzureFunction.Data.Interface;
using Microsoft.Extensions.DependencyInjection;


namespace AzureFunction.Data
{
    public static class DataConfiguration
    {
        public static void ConfigureData(this IServiceCollection services)
        {
            services.AddSingleton<IDataContextFactory, DataContextFactory>();
        }
    }
}
