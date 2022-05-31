using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBooks.Controllers
{
    public class KategoriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
