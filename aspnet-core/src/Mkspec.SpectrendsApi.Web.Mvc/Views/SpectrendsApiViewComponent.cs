using Abp.AspNetCore.Mvc.ViewComponents;

namespace Mkspec.SpectrendsApi.Web.Views
{
    public abstract class SpectrendsApiViewComponent : AbpViewComponent
    {
        protected SpectrendsApiViewComponent()
        {
            LocalizationSourceName = SpectrendsApiConsts.LocalizationSourceName;
        }
    }
}
