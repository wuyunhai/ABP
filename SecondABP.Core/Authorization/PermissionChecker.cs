using Abp.Authorization;
using SecondABP.Authorization.Roles;
using SecondABP.Authorization.Users;

namespace SecondABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
