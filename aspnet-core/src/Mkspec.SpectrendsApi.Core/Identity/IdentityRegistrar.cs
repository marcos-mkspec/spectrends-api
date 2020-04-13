using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Mkspec.SpectrendsApi.Authorization;
using Mkspec.SpectrendsApi.Authorization.Roles;
using Mkspec.SpectrendsApi.Authorization.Users;
using Mkspec.SpectrendsApi.Editions;
using Mkspec.SpectrendsApi.MultiTenancy;

namespace Mkspec.SpectrendsApi.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
