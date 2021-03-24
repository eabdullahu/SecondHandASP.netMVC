using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SecondHand.Data;
using SecondHand.Models;
using SecondHand.Models.Homepage;

namespace SecondHand.Controllers {
    public class SearchController : Controller
    {
        private readonly SecondHandContext _context;
        public SearchController(SecondHandContext context) {
            _context = context;
        }
        public async Task<IActionResult> Index(int cid, string search, string size, string sortby, int perpage = 4, int page = 1) {

            List<SelectListItem> showPerPage = new List<SelectListItem> {
                new SelectListItem {Text = "4", Value = "4"},
                new SelectListItem {Text = "12", Value = "12"},
                new SelectListItem {Text = "24", Value = "24"},
                new SelectListItem {Text = "36", Value = "36"},
                new SelectListItem {Text = "48", Value = "48"},
            };

            List<SelectListItem> orderBy = new List<SelectListItem> {
                new SelectListItem {Text = "Featured", Value = "ft"},
                new SelectListItem {Text = "Price, low to high", Value = "lth"},
                new SelectListItem {Text = "Price, high to low", Value = "htl"},
            };

            ViewData["showPerPage"] = showPerPage;
            ViewData["orderBy"] = orderBy;
            ViewData["search"] = search;
            ViewData["category"] = cid;

            Homepage homepage = new Homepage();
            homepage.Hp_Categories = (IEnumerable<Categories>)await _context.Categories.ToListAsync();

            var products = _context.Products.AsQueryable();
            if(cid != 0) {
                products = products.Where(p => p.categoryId == cid);
            }
            if (!String.IsNullOrEmpty(search)){
                products = products.Where(p => p.productTitle.Contains(search) || p.productDesc.Contains(search));
            }

            switch (sortby) {
                case "lth":
                    products = products.OrderBy(p => p.productPrice);
                    break;
                case "htl":
                    products = products.OrderByDescending(p => p.productPrice);
                    break;
                default:
                    products = products.OrderByDescending(p => p.productId);
                    break;
            }

            ViewData["totalPage"] = products.Count();
            if (page < 1 || page > (int)Math.Ceiling(Convert.ToDouble(ViewData["totalPage"]) / perpage)) {
                page = 1;
            }
            ViewData["pageindex"] = page;
            ViewData["itemToShow"] = perpage;
            var getFrom = (page - 1) * perpage;

            homepage.Hp_Products = (IEnumerable<Products>)await products.Skip(getFrom).Take(perpage).Include(p => p.Photos).ToListAsync();

            ViewData["Categories"] = (List<Tuple<int, string>>) _context.Products.Include(p => p.Categories).
                GroupBy(p => new { id = p.categoryId, title = p.Categories.categoryTitle }).
                    Select(g => Tuple.Create(g.Key.id, g.Key.title + " (" + g.Count() + ")")).ToList();

            ViewData["Selected"] = sortby;
            return View(homepage);
        }
    }
}
