using System.Collections.Generic;
using Bicisim.Roles.Dto;

namespace Bicisim.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
