using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using RAdminstration.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAdminstration.PhoneBooks.PhoneNumbers
{
    public class PhoneNumber : Entity<long>,IHasCreationTime
    {
        [Required]
        [MaxLength(11)]
        public string Number { get; set; }
        public DateTime CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PhoneNumberType Type { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
    /// <summary>
    /// 电话号码类型
    /// </summary>
    public enum PhoneNumberType
    {
        [Display(Name = "移动电话")]
        Mobile,
        [Display(Name = "座机")]
        Home,
        [Display(Name = "公司电话")]
        Company
    }
}
