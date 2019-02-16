using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Abp.BG.Configuration.Dto;

namespace Abp.BG.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BGAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
