using System.Collections.Generic;
using Mkspec.SpectrendsApi.Roles.Dto;

namespace Mkspec.SpectrendsApi.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
