﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using RAdminstration.Controllers;

namespace RAdminstration.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : RAdminstrationControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
