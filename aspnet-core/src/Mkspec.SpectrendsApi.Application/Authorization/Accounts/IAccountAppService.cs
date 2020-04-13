using System.Threading.Tasks;
using Abp.Application.Services;
using Mkspec.SpectrendsApi.Authorization.Accounts.Dto;

namespace Mkspec.SpectrendsApi.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
