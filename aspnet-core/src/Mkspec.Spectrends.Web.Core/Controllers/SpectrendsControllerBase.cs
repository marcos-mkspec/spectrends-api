using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Mkspec.Spectrends.Controllers
{
    public abstract class SpectrendsControllerBase: AbpController
    {
        protected SpectrendsControllerBase()
        {
            LocalizationSourceName = SpectrendsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
