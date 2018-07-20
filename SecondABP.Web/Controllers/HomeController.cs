﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SecondABP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SecondABPControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}