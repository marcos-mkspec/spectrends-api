using Abp.Authorization;
using Mkspec.Spectrends.Authorization.Roles;
using Mkspec.Spectrends.Authorization.Users;

namespace Mkspec.Spectrends.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
