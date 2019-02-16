using Abp.Authorization;
using Abp.BG.Authorization.Roles;
using Abp.BG.Authorization.Users;

namespace Abp.BG.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
