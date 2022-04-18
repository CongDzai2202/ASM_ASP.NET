using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopOnline_ASM_NET104_CONGNCPH14366.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline_ASM_NET104_CONGNCPH14366.Controllers
{
    public class ProductController : Controller
    {
        private readonly ShopOnlineContext _context;
        public ProductController(ShopOnlineContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            var product = _context.Products.Include(c => c.Cat).FirstOrDefault(x => x.ProductId == id);
            if(product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }

    }
}
