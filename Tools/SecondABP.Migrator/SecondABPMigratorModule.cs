using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SecondABP.EntityFramework;

namespace SecondABP.Migrator
{
    [DependsOn(typeof(SecondABPDataModule))]
    public class SecondABPMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SecondABPDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}