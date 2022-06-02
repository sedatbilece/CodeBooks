using CodeBooks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBooks.Controllers
{
    // en son [Authorize] ekle
    public class MakaleController : Controller
    {

        Context c = new Context();
        public IActionResult Index()
        {
            ViewBag.kategoriad = c.Kategoris.ToList();
            
            var degerler = c.Makales.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult MakaleEkle()
        {


            List<SelectListItem> degerler = (from x in c.Kategoris.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.KategoriAd,
                                                 Value = x.KategoriID.ToString()
                                             }).ToList();

            ViewBag.dgr = degerler;

            return View();
        }
        [HttpPost]
        public IActionResult MakaleEkle( Makale m)
        {

            var kat = c.Kategoris.Where(x => x.KategoriID == m.kategori.KategoriID).FirstOrDefault();
            m.Tarih = "22.04.2021";
            m.kategori = kat;
            c.Makales.Add(m);
            c.SaveChanges();



            return RedirectToAction("Index", "Makale");
        }



    }
}
