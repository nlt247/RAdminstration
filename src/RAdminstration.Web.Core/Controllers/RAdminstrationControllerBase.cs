using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace RAdminstration.Controllers
{
    public abstract class RAdminstrationControllerBase: AbpController
    {
        protected RAdminstrationControllerBase()
        {
            LocalizationSourceName = RAdminstrationConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
