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


        public IActionResult GirisYap()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> GirisYapAsync(Admin a)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.userName == a.userName && x.password == a.password);

            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,a.userName)
                };

                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Admin");
            }


            return View();
        }






        [HttpGet]
        public async Task<IActionResult> CikisYap()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);


            return RedirectToAction("Index", "Home");
        }




    }
}
