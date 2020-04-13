using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Mkspec.SpectrendsApi.Authorization;

namespace Mkspec.SpectrendsApi
{
    [DependsOn(
        typeof(SpectrendsApiCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SpectrendsApiApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SpectrendsApiAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SpectrendsApiApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
