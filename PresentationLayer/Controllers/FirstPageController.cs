﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class FirstPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
