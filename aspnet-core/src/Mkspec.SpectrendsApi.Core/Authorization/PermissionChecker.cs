using Abp.Authorization;
using Mkspec.SpectrendsApi.Authorization.Roles;
using Mkspec.SpectrendsApi.Authorization.Users;

namespace Mkspec.SpectrendsApi.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
