using Abp.Authorization;
using RAdminstration.Authorization.Roles;
using RAdminstration.Authorization.Users;

namespace RAdminstration.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
