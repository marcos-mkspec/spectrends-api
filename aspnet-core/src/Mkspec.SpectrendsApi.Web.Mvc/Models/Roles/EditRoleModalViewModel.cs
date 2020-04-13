using Abp.AutoMapper;
using Mkspec.SpectrendsApi.Roles.Dto;
using Mkspec.SpectrendsApi.Web.Models.Common;

namespace Mkspec.SpectrendsApi.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
