using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecondHand.Data;
using SecondHand.Enums;
using SecondHand.Models;
using SecondHand.Models.AdminHomepage;

namespace SecondHand.Controllers
{

    [Authorize(Roles = "SuperAdmin")]
    public class AdminHomeController : Controller
    {

        private readonly SecondHandContext _context;
        public AdminHomeController(SecondHandContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            AdminHomepage adminHomepage  = new AdminHomepage();
            adminHomepage.Hp_Products = (IEnumerable<Products>)await _context.Products.OrderByDescending(p => p.productId).Take(8).Include(p => p.Photos).ToListAsync();
            adminHomepage.Hp_Contents = (IEnumerable<Contents>)await _context.Contents.Where(b => b.contentPage == "homepage").ToListAsync();

            return View(adminHomepage);
        }

      


    }
}
