using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Mkspec.SpectrendsApi.Controllers
{
    public abstract class SpectrendsApiControllerBase: AbpController
    {
        protected SpectrendsApiControllerBase()
        {
            LocalizationSourceName = SpectrendsApiConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
