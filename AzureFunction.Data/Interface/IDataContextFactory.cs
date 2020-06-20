using System;
using System.Collections.Generic;
using System.Text;

namespace AzureFunction.Data.Interface
{
    public interface IDataContextFactory
    {
        DataContext CreateDbContext(string[] ars);
    }
}
