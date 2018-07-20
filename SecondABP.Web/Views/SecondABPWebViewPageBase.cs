using Abp.Web.Mvc.Views;

namespace SecondABP.Web.Views
{
    public abstract class SecondABPWebViewPageBase : SecondABPWebViewPageBase<dynamic>
    {

    }

    public abstract class SecondABPWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SecondABPWebViewPageBase()
        {
            LocalizationSourceName = SecondABPConsts.LocalizationSourceName;
        }
    }
}