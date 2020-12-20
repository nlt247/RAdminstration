using System.Collections.Generic;
using RAdminstration.Roles.Dto;

namespace RAdminstration.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
