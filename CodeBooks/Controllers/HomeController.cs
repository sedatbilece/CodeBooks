using CodeBooks.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBooks.Controllers
{

    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult BlogPost()// blog yazisi içerik sayfası (int id ) alacak
        {
            return View();
        }

        public IActionResult KategoriListesi() // Liste dönecek 
        {
            return View();
        }
        public IActionResult MakaleListesi()// kategoriye bağlı yazilar (int id) alcak 
        {
            return View();
        }

        






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
