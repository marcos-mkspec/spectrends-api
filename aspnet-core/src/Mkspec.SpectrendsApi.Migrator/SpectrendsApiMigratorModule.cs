using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Mkspec.SpectrendsApi.Configuration;
using Mkspec.SpectrendsApi.EntityFrameworkCore;
using Mkspec.SpectrendsApi.Migrator.DependencyInjection;

namespace Mkspec.SpectrendsApi.Migrator
{
    [DependsOn(typeof(SpectrendsApiEntityFrameworkModule))]
    public class SpectrendsApiMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SpectrendsApiMigratorModule(SpectrendsApiEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(SpectrendsApiMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                SpectrendsApiConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(SpectrendsApiMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
