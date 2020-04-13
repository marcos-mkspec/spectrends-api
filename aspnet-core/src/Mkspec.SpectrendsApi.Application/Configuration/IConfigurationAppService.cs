using System.Threading.Tasks;
using Mkspec.SpectrendsApi.Configuration.Dto;

namespace Mkspec.SpectrendsApi.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
