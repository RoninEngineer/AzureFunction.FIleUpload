using System;
using Microsoft.EntityFrameworkCore;

namespace AzureFunction.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}
