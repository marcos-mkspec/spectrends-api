using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Mkspec.Spectrends.MultiTenancy;

namespace Mkspec.Spectrends.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
