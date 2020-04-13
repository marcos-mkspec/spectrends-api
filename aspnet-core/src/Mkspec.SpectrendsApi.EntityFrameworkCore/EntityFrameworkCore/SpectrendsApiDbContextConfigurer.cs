using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Mkspec.SpectrendsApi.EntityFrameworkCore
{
    public static class SpectrendsApiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SpectrendsApiDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SpectrendsApiDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
