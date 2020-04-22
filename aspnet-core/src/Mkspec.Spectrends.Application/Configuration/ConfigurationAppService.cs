using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Mkspec.Spectrends.Configuration.Dto;

namespace Mkspec.Spectrends.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SpectrendsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
