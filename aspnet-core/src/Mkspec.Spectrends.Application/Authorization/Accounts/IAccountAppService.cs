using System.Threading.Tasks;
using Abp.Application.Services;
using Mkspec.Spectrends.Authorization.Accounts.Dto;

namespace Mkspec.Spectrends.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
