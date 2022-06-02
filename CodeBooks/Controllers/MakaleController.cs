using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBooks.Controllers
{
    // en son [Authorize] ekle
    public class MakaleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
