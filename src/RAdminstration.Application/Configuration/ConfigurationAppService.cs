using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using RAdminstration.Configuration.Dto;

namespace RAdminstration.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : RAdminstrationAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
