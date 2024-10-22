using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using softtest.Configuration.Dto;

namespace softtest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : softtestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
