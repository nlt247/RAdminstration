using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using RAdminstration.PhoneBooks.Persons;
using RAdminstration.PhoneBooks.PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAdminstration.PhoneBooks.Dto
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto : FullAuditedEntityDto
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
