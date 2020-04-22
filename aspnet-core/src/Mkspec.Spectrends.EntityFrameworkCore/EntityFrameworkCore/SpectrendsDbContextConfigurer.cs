using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Mkspec.Spectrends.EntityFrameworkCore
{
    public static class SpectrendsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SpectrendsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SpectrendsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
