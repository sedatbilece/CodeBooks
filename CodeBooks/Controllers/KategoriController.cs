using CodeBooks.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBooks.Controllers
{



    // en son [Authorize] ekle
    [Authorize]
    public class KategoriController : Controller
    {

        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Kategoris.ToList();


            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniKategori()
        {

            return View();
        }

        [HttpPost]
        public IActionResult YeniKategori(Kategori k)
        {

            c.Kategoris.Add(k);
            c.SaveChanges();



            return RedirectToAction("Index", "Kategori");
        }
        

        public IActionResult KategoriGetir(int id)
        {
            var kat = c.Kategoris.Find(id);

            


            return View(kat);
        }

        public IActionResult KategoriUpdate(Kategori k)
        {

            var kat = c.Kategoris.Find(k.KategoriID);
            kat.KategoriAd = k.KategoriAd;

            c.SaveChanges();



            return RedirectToAction("Index", "Kategori");
        }


        public IActionResult AktifEt(int id)
        {
            var kat = c.Kategoris.FirstOrDefault(x => x.KategoriID == id);

            kat.Aktiflik = 1;

            c.SaveChanges();


            return RedirectToAction("Index", "Kategori");
        }

        public IActionResult PasifEt(int id)
        {
            var kat = c.Kategoris.FirstOrDefault(x => x.KategoriID == id);

            kat.Aktiflik = 0;

            c.SaveChanges();


            return RedirectToAction("Index", "Kategori");
        }



    }
}
