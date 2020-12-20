using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RAdminstration.Configuration;
using RAdminstration.Web;

namespace RAdminstration.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RAdminstrationDbContextFactory : IDesignTimeDbContextFactory<RAdminstrationDbContext>
    {
        public RAdminstrationDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RAdminstrationDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RAdminstrationDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RAdminstrationConsts.ConnectionStringName));

            return new RAdminstrationDbContext(builder.Options);
        }
    }
}
