using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using RAdminstration.PhoneBooks.Persons;
using RAdminstration.PhoneBooks.PhoneNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAdminstration.PhoneBooks.Dto
{
    [AutoMapTo(typeof(Person))]
    public class PersonEditDto 
    {
        public int? Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [Required]
        [EmailAddress]
        [MaxLength(80)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [MaxLength(200)]
        public string Address { get; set; }

        public virtual List<PhoneNumber> PhoneNumberList { get; set; }
    }
}
