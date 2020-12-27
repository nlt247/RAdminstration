using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace RAdminstration.Dto
{
    public class PagedAndSortedInputDto : IPagedAndSortedResultRequest, ISortedResultRequest
    {
        public string Sorting { get; set; }

        [Range(0,int.MaxValue)]
        public int SkipCount { get; set; }
        [Range(1,500)]
        public int MaxResultCount { get; set; }

    }
}
