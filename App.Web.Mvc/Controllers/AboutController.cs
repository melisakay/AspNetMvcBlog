﻿using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
