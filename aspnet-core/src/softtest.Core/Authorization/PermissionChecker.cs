using Abp.Authorization;
using softtest.Authorization.Roles;
using softtest.Authorization.Users;

namespace softtest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
