using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Mkspec.Spectrends.Configuration;
using Mkspec.Spectrends.EntityFrameworkCore;
using Mkspec.Spectrends.Migrator.DependencyInjection;

namespace Mkspec.Spectrends.Migrator
{
    [DependsOn(typeof(SpectrendsEntityFrameworkModule))]
    public class SpectrendsMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SpectrendsMigratorModule(SpectrendsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(SpectrendsMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                SpectrendsConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SpectrendsMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
