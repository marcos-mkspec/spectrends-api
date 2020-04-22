using System.Threading.Tasks;
using Mkspec.Spectrends.Configuration.Dto;

namespace Mkspec.Spectrends.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
