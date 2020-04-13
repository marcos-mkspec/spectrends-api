using System.Collections.Generic;
using Mkspec.SpectrendsApi.Roles.Dto;

namespace Mkspec.SpectrendsApi.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
