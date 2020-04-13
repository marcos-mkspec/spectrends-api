using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Mkspec.SpectrendsApi.Configuration;

namespace Mkspec.SpectrendsApi.Web.Startup
{
    [DependsOn(typeof(SpectrendsApiWebCoreModule))]
    public class SpectrendsApiWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SpectrendsApiWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<SpectrendsApiNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SpectrendsApiWebMvcModule).GetAssembly());
        }
    }
}
