using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Mkspec.Spectrends.Authorization.Roles;
using Mkspec.Spectrends.Authorization.Users;
using Mkspec.Spectrends.MultiTenancy;

namespace Mkspec.Spectrends.EntityFrameworkCore
{
    public class SpectrendsDbContext : AbpZeroDbContext<Tenant, Role, User, SpectrendsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SpectrendsDbContext(DbContextOptions<SpectrendsDbContext> options)
            : base(options)
        {
        }
    }
}
