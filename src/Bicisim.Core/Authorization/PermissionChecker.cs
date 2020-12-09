using Abp.Authorization;
using Bicisim.Authorization.Roles;
using Bicisim.Authorization.Users;

namespace Bicisim.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
