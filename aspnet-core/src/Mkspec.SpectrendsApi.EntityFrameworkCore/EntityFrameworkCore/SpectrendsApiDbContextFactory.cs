using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Mkspec.SpectrendsApi.Configuration;
using Mkspec.SpectrendsApi.Web;

namespace Mkspec.SpectrendsApi.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SpectrendsApiDbContextFactory : IDesignTimeDbContextFactory<SpectrendsApiDbContext>
    {
        public SpectrendsApiDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SpectrendsApiDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SpectrendsApiDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SpectrendsApiConsts.ConnectionStringName));

            return new SpectrendsApiDbContext(builder.Options);
        }
    }
}
