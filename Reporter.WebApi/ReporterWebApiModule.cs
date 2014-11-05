using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace Reporter
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ReporterApplicationModule))]
    public class ReporterWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ReporterApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
