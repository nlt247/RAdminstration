using System.Collections.Generic;
using RAdminstration.Roles.Dto;

namespace RAdminstration.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}