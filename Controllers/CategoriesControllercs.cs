﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesControllercs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Food()
        {
            return View();
        }

        public IActionResult Tech()
        {
            return View();
        }

        public IActionResult Sports()
        {
            return View();
        }
    }
}
