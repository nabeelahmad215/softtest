using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace softtest.Controllers
{
    public abstract class softtestControllerBase: AbpController
    {
        protected softtestControllerBase()
        {
            LocalizationSourceName = softtestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
