using Abp.Web.Mvc.Views;

namespace Reporter.Web.Views
{
    public abstract class ReporterWebViewPageBase : ReporterWebViewPageBase<dynamic>
    {

    }

    public abstract class ReporterWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ReporterWebViewPageBase()
        {
            LocalizationSourceName = ReporterConsts.LocalizationSourceName;
        }
    }
}