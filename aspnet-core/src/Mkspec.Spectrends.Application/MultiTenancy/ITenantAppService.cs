using Abp.Application.Services;
using Mkspec.Spectrends.MultiTenancy.Dto;

namespace Mkspec.Spectrends.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

