using Abp.Web.Mvc.Controllers;

namespace Reporter.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ReporterControllerBase : AbpController
    {
        protected ReporterControllerBase()
        {
            LocalizationSourceName = ReporterConsts.LocalizationSourceName;
        }
    }
}