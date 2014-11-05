using Abp.Application.Services;

namespace Reporter
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ReporterAppServiceBase : ApplicationService
    {
        protected ReporterAppServiceBase()
        {
            LocalizationSourceName = ReporterConsts.LocalizationSourceName;
        }
    }
}