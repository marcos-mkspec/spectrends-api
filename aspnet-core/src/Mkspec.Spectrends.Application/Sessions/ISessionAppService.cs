using System.Threading.Tasks;
using Abp.Application.Services;
using Mkspec.Spectrends.Sessions.Dto;

namespace Mkspec.Spectrends.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
