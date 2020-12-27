using Abp.Application.Services.Dto;
using RAdminstration.PhoneBooks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAdminstration.Web.Models.Person
{
    public class PersonListViewModel
    {
        public IReadOnlyList<PagedResultDto<PersonListDto>> PersonViewList { get; set; }
    }
}
