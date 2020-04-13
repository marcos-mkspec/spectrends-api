using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using Mkspec.SpectrendsApi.Authorization.Roles;
using Mkspec.SpectrendsApi.Authorization.Users;
using Mkspec.SpectrendsApi.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace Mkspec.SpectrendsApi.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
