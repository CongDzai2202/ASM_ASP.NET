using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopOnline_ASM_NET104_CONGNCPH14366.Models;
using ShopOnline_ASM_NET104_CONGNCPH14366.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline_ASM_NET104_CONGNCPH14366.Controllers
{
    public class AccountController : Controller
    {
        ShopOnlineContext _db = new ShopOnlineContext();
        public AccountController(ShopOnlineContext db)
        {
            _db = db;
        }

        public IActionResult Login(string Email, string Pass)
        {
            if (!string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Pass))
            {
                var TK = _db.Accounts.FirstOrDefault(c => c.Email == Email && c.Pass == Pass && c.RoleId == 1);
                var TK1 = _db.Accounts.FirstOrDefault(c => c.Email == Email && c.Pass == Pass && c.RoleId == 0);
                if (TK != null)
                {
                    //HttpContext.Session.SetString("Email", Email);
                    //HttpContext.Session.SetString("Pass", Pass);
                   // return RedirectToAction("Index", "Admin");
                    return RedirectToAction("Index", "Home");
                }
                else if (TK1 != null)
                {
                    //HttpContext.Session.SetString("Email", Email);
                    //HttpContext.Session.SetString("Pass", Pass);
                    return RedirectToAction("Index","Admin");
                }
                else
                {
                    ViewData["Notfound"] = Email;
                }
            }
            return View();
        }
        public IActionResult Show()
        {
            string Email = HttpContext.Session.GetString("Email");
            string Pass = HttpContext.Session.GetString("Pass");
            ViewData["Email"] = Email;
            ViewData["Pass"] = Pass;
            return View();
        }
        //[HttpPost]
        //[AllowAnonymous]
        //[Route("dang-nhap.html",Name ="DangNhap")]
        //public async Task<IActionResult> IActionResult Login(LoginViewModel customer,string returnUrl = null)
        //{
        //    try
        //    {
        //        string pass
        //    }
        //    catch 
        //}
    }
}
