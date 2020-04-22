using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Mkspec.Spectrends.Authorization;

namespace Mkspec.Spectrends
{
    [DependsOn(
        typeof(SpectrendsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SpectrendsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SpectrendsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SpectrendsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
