using System.Linq;
using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace Reporter
{
    /// <summary>
    /// 'Web API layer module' for this project.
    /// </summary>
    [DependsOn(typeof(AbpWebApiModule), typeof(ReporterApplicationModule))]
    public class ReporterWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            //This code is used to register classes to dependency injection system for this assembly using conventions.
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            var assembly = typeof(ReporterApplicationModule).Assembly;
            foreach (var type in assembly.GetTypes())
            {
                if (!type.IsPublic)
                    continue;
                if (!type.IsInterface)
                    continue;
                if (!typeof(IApplicationService).IsAssignableFrom(type))
                    continue;
                if (!IocManager.IsRegistered(type))
                    continue;
                System.Diagnostics.Debug.Print(type.Name);
            }

            //Creating dynamic Web Api Controllers for application services.
            //Thus, 'web api layer' is created automatically by ABP.
            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ReporterApplicationModule).Assembly, "reporter")
                .Build();
        }
    }
}