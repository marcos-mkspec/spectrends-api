using Abp.Application.Services;
using Mkspec.SpectrendsApi.MultiTenancy.Dto;

namespace Mkspec.SpectrendsApi.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

