using Abp.AutoMapper;
using Mkspec.SpectrendsApi.Sessions.Dto;

namespace Mkspec.SpectrendsApi.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
