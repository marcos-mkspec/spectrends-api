using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Mkspec.Spectrends.Configuration;

namespace Mkspec.Spectrends.Web.Host.Startup
{
    [DependsOn(
       typeof(SpectrendsWebCoreModule))]
    public class SpectrendsWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SpectrendsWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SpectrendsWebHostModule).GetAssembly());
        }
    }
}
