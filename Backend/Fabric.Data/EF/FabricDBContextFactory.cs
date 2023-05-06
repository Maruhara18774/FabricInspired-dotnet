using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fabric.Data.EF
{
    public class FabricDBContextFactory : IDesignTimeDbContextFactory<FabricDBContext>
    {
        public FabricDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("LulusDatabase");

            var optionBuilder = new DbContextOptionsBuilder<FabricDBContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new FabricDBContext(optionBuilder.Options);
        }
    }
}
