﻿using Microsoft.AspNetCore.Mvc;

namespace EasyEcommerce.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
