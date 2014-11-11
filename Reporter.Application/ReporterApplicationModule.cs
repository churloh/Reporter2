using System.Reflection;
using Abp.Modules;

namespace Reporter
{
    [DependsOn(typeof(ReporterCoreModule))]
    public class ReporterApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            DtoMappings.Map();
        }
    }
}
