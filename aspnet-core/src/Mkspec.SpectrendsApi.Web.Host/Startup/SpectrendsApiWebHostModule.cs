using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Mkspec.SpectrendsApi.Configuration;

namespace Mkspec.SpectrendsApi.Web.Host.Startup
{
    [DependsOn(
       typeof(SpectrendsApiWebCoreModule))]
    public class SpectrendsApiWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SpectrendsApiWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SpectrendsApiWebHostModule).GetAssembly());
        }
    }
}
