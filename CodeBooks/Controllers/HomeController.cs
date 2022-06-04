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
        Context c = new Context();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            

            var maks = c.Makales.OrderByDescending(x => x.MakaleID).ToList();
            return View(maks);
        }


        public IActionResult BlogPost(int id)// blog yazisi içerik sayfası (int id ) alacak
        {
           var postmakale=  c.Makales.Find(id);

            if (postmakale == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(postmakale);
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
