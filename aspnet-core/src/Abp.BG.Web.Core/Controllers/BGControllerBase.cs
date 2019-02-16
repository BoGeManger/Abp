using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Abp.BG.Controllers
{
    public abstract class BGControllerBase: AbpController
    {
        protected BGControllerBase()
        {
            LocalizationSourceName = BGConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
