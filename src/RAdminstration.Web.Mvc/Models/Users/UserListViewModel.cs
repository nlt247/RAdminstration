using System.Collections.Generic;
using RAdminstration.Roles.Dto;

namespace RAdminstration.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
