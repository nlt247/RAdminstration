using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RAdminstration.Controllers;
using RAdminstration.PhoneBooks;
using RAdminstration.PhoneBooks.Dto;
using RAdminstration.Web.Models.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAdminstration.Web.Controllers
{
    [AbpMvcAuthorize]
    public class PersonsController : RAdminstrationControllerBase
    {
        public readonly IPersonAppService _personAppService;
        private readonly IMapper _mapper;
        public PersonsController(IPersonAppService personAppService, IMapper mapper)
        {
            _personAppService = personAppService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            //var person = await _personAppService.GetPagedPersonAsync(input);
            return View();
        }
        public async Task<ActionResult> EditModal(int personId)
        {
            var output = await _personAppService.GetPersonByIdAsync(new NullableIdDto(personId));
            //var model = _mapper.Map<EditPersonViewModel>(output);

            return PartialView("_EditModal", output);
        }
    }
}
