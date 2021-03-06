﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeepDiveTranslationWeb.Models;
using System.Globalization;
using Microsoft.Extensions.Localization;
using DeepDiveTranslationWeb.Resources;

namespace DeepDiveTranslationWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer localizer;
        public HomeController(IStringLocalizerFactory factory)
        {
            localizer = factory.Create(typeof(SharedResources));
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = CultureInfo.CurrentCulture.ToString();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = localizer["ContactUs"];

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
