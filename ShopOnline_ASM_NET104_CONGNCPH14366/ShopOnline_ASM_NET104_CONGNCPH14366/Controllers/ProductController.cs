using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
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

        [Route("shop.html", Name = "ShopProduct")]
        public IActionResult Index(int? page)
        {

            try
            { 
                var pageNumber = page == null || page <= 0 ? 1 : page.Value;
                var pageSize = 10;
                var lst = _context.Products.AsNoTracking().OrderByDescending(c => c.DateCreated);
                PagedList<Product> models = new PagedList<Product>(lst, pageNumber, pageSize);
                ViewBag.CurrentPage = pageNumber;
                return View(models);
            }
            catch (Exception)
            {

                return RedirectToAction("Index","Home");
            }
        }
        [Route("/{Alias}-{ID}", Name = "ListProduct")]
        public IActionResult List(int CatID,int page = 1)
        {
            try
            {
                var pageSize = 10;
                var Danhmuc = _context.Categories.Find(CatID);
                var lst = _context.Products.AsNoTracking().Where(c=>c.CatId == CatID).OrderByDescending(c => c.DateCreated);
                PagedList<Product> models = new PagedList<Product>(lst, page, pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCat = page;
                return View(models);
            }
            catch (Exception)
            {

                return RedirectToAction("Index", "Home");
            }
        }
        [Route("/{Alias}-{id}.html", Name = "ProductDetails")]
        public IActionResult Detail(int id)
        {

            var product = _context.Products.Include(c => c.Cat).FirstOrDefault(x => x.ProductId == id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);


        }

    }
}
