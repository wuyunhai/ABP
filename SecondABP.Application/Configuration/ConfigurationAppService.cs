using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SecondABP.Configuration.Dto;

namespace SecondABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SecondABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
