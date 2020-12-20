using Abp.AspNetCore.Mvc.ViewComponents;

namespace RAdminstration.Web.Views
{
    public abstract class RAdminstrationViewComponent : AbpViewComponent
    {
        protected RAdminstrationViewComponent()
        {
            LocalizationSourceName = RAdminstrationConsts.LocalizationSourceName;
        }
    }
}
