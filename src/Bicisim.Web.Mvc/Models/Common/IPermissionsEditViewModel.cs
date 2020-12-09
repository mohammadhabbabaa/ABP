using System.Collections.Generic;
using Bicisim.Roles.Dto;

namespace Bicisim.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}