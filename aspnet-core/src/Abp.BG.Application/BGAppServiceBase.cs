using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Abp.BG.Authorization.Users;
using Abp.BG.MultiTenancy;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Abp.BG.Configuration;

namespace Abp.BG
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BGAppServiceBase : ApplicationService
    {
        public IConfigurationRoot _appConfiguration { get; set; }

        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected BGAppServiceBase()
        {
            LocalizationSourceName = BGConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }

        protected virtual string PathUrl(string name)
        {
            var path = string.Format("{0}:{1}", BGConsts.AppSettingsPathUrl, name);
            return _appConfiguration[path].ToString();
        }

        protected virtual string Consts(string name)
        {
            var path = string.Format("{0}:{1}", BGConsts.AppSettingsConsts, name);
            return _appConfiguration[path].ToString();
        }

        protected virtual IConfigurationRoot GetAppConfiguration(IHostingEnvironment env)
        {
            return AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName, env.IsDevelopment());
        }
    }
}
