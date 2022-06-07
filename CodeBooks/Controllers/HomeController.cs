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
          var deg  =  c.Kategoris.Where(x => x.Aktiflik == 1).ToList();
            return View(deg);
        }
        public IActionResult MakaleListesi(int id)// kategoriye bağlı yazilar (int id) alcak 
        {
            var deg = c.Makales.Where(x => x.KategoriID == id).ToList();
           var katadi = c.Kategoris.Find(id);
            if (katadi == null)
            {
                ViewBag.katadi = "";
            }
            else
            {
                ViewBag.katadi = katadi.KategoriAd;
            }
            if (deg == null)
            {
                ViewBag.kontrol = 0;
            }
            else
            {
                ViewBag.kontrol = 1;
            }
           
            return View(deg);
        }

        






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
