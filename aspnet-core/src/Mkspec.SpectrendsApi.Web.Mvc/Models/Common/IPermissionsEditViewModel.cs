using System.Collections.Generic;
using Mkspec.SpectrendsApi.Roles.Dto;

namespace Mkspec.SpectrendsApi.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}