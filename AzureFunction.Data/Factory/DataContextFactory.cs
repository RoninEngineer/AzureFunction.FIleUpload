using AzureFunction.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AzureFunction.Data.Factory
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>, IDataContextFactory
    {
        public DataContext CreateDbContext(string[] ars)
        {
            var builder = new DbContextOptionsBuilder<DataContext>();
            builder.UseInMemoryDatabase<DataContext>("InMemoryTestingDb");
            return new DataContext(builder.Options);
        }
    }
}
