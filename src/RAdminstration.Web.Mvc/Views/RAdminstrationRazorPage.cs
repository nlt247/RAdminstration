using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace RAdminstration.Web.Views
{
    public abstract class RAdminstrationRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected RAdminstrationRazorPage()
        {
            LocalizationSourceName = RAdminstrationConsts.LocalizationSourceName;
        }
    }
}
