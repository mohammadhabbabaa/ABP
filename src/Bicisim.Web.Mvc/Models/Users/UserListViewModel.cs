using System.Collections.Generic;
using Bicisim.Roles.Dto;

namespace Bicisim.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
