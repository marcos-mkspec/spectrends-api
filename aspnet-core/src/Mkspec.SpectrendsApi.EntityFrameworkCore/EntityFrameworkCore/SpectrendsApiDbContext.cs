using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Mkspec.SpectrendsApi.Authorization.Roles;
using Mkspec.SpectrendsApi.Authorization.Users;
using Mkspec.SpectrendsApi.MultiTenancy;

namespace Mkspec.SpectrendsApi.EntityFrameworkCore
{
    public class SpectrendsApiDbContext : AbpZeroDbContext<Tenant, Role, User, SpectrendsApiDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SpectrendsApiDbContext(DbContextOptions<SpectrendsApiDbContext> options)
            : base(options)
        {
        }
    }
}
