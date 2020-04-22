using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Mkspec.Spectrends.Configuration;
using Mkspec.Spectrends.Web;

namespace Mkspec.Spectrends.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SpectrendsDbContextFactory : IDesignTimeDbContextFactory<SpectrendsDbContext>
    {
        public SpectrendsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SpectrendsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SpectrendsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SpectrendsConsts.ConnectionStringName));

            return new SpectrendsDbContext(builder.Options);
        }
    }
}
