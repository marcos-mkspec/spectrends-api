using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Mkspec.SpectrendsApi.Configuration.Dto;

namespace Mkspec.SpectrendsApi.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SpectrendsApiAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
