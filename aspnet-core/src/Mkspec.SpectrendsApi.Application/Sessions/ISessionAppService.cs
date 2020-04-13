using System.Threading.Tasks;
using Abp.Application.Services;
using Mkspec.SpectrendsApi.Sessions.Dto;

namespace Mkspec.SpectrendsApi.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
