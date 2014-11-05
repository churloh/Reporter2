using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Reporter.EntityFramework;

namespace Reporter
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(ReporterCoreModule))]
    public class ReporterDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<ReporterDbContext>(null);
        }
    }
}
