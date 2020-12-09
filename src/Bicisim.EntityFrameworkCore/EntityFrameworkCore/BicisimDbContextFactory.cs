using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Bicisim.Configuration;
using Bicisim.Web;

namespace Bicisim.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BicisimDbContextFactory : IDesignTimeDbContextFactory<BicisimDbContext>
    {
        public BicisimDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BicisimDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BicisimDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BicisimConsts.ConnectionStringName));

            return new BicisimDbContext(builder.Options);
        }
    }
}
