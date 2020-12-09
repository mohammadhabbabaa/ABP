using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Bicisim.Controllers
{
    public abstract class BicisimControllerBase: AbpController
    {
        protected BicisimControllerBase()
        {
            LocalizationSourceName = BicisimConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
