using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Bicisim.Configuration.Dto;

namespace Bicisim.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BicisimAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
