using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecondHand.Data;
using SecondHand.Models;
using SecondHand.Models.Homepage;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace SecondHand.Controllers
{
    
    public class HomeController : Controller
    {

        private readonly SecondHandContext _context;
        public HomeController(SecondHandContext context) {
            _context = context;
        }

        public async Task<IActionResult> Index() {
            Homepage homepage = new Homepage();
            homepage.Hp_Categories = (IEnumerable<Categories>) await _context.Categories.ToListAsync();
            homepage.Hp_Products = (IEnumerable<Products>) await _context.Products.OrderByDescending(p => p.productId).Take(8).Include(p => p.Photos).ToListAsync();
            homepage.Hp_Contents = (IEnumerable<Contents>) await _context.Contents.Where(b => b.contentPage == "homepage").ToListAsync();

            return View(homepage);
        }
    }
}
