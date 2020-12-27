using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using RAdminstration.PhoneBooks.Dto;
using RAdminstration.PhoneBooks.PhoneNumbers;
using RAdminstration.Roles.Dto;
using RAdminstration.Web.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAdminstration.Web.Models.Person
{
    [AutoMapFrom(typeof(PersonListDto))]
    public class EditPersonViewModel : FullAuditedEntityDto
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        public virtual List<PhoneNumber> PhoneNumberList { get; set; }
    }
}
