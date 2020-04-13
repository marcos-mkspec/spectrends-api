using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Mkspec.SpectrendsApi.Web.Views
{
    public abstract class SpectrendsApiRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SpectrendsApiRazorPage()
        {
            LocalizationSourceName = SpectrendsApiConsts.LocalizationSourceName;
        }
    }
}
