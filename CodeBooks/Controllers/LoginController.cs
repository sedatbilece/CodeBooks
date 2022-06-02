using CodeBooks.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CodeBooks.Controllers
{
    public class LoginController : Controller
    {

        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }



        // form sayfasını döndürüror 
        public IActionResult GirisYap()
        {
            return View();
        }



        // form gönderildiğinde asenkron olarak çalışır
        [HttpPost]
        //                                             formdan gelen biligileri admin modelinde gelir
        public async Task<IActionResult> GirisYapAsync(Admin a)
        {
            // veritab böyle bir bilgi varmı kontrolü
            var bilgiler = c.Admins.FirstOrDefault(x => x.userName == a.userName && x.password == a.password);


            //var ise
            if (bilgiler != null)// authorize işlemleri
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,a.userName)
                };

                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Admin");// işlem başarılı ise şifre istenen sayfaya atar
            }


            return View();// işlem başarısız ise bizi login sayfasına geri döndürür
        }





        // authorize işlemini manuel bitirme
        [HttpGet]
        public async Task<IActionResult> CikisYap()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);


            return RedirectToAction("Index", "Home");
        }




    }
}
