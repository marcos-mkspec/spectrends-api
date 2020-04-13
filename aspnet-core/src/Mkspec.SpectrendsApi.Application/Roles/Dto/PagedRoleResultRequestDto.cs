using Abp.Application.Services.Dto;

namespace Mkspec.SpectrendsApi.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

