using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecondHand.Data;
using SecondHand.Models;
using SecondHand.Models.Homepage;

namespace SecondHand.Controllers
{
    public class CartController : Controller {

        private readonly SecondHandContext _context;
        Cart cart = new Cart();
        public CartController(SecondHandContext context) {
            _context = context;
        }
        public async Task<IActionResult> Index() {
            Homepage home = new Homepage();
            home.Hp_Categories = (IEnumerable<Categories>)await _context.Categories.ToListAsync();
            return View(home);
        }

        [HttpPost]
        public async Task<IActionResult> Index(int[] quanityVal) {
            List<Products> _sessionList = Sessions.GetObjectFromJson<List<Products>>(HttpContext.Session, "cart");
            var totali = 0.00;
            for(int i = 0; i < _sessionList.Count(); i++) {
                _sessionList.ElementAt(i).productPriceTotal = Math.Round(_sessionList.ElementAt(i).productPrice * quanityVal[i], 1);
                _sessionList.ElementAt(i).productQuanitity = quanityVal[i];
                totali += _sessionList.ElementAt(i).productPriceTotal;
            }
            Sessions.SetObjectAsJson(HttpContext.Session, "cart", _sessionList);
            Sessions.SetObjectAsJson(HttpContext.Session, "cart_total", totali);

            Homepage home = new Homepage();
            home.Hp_Categories = (IEnumerable<Categories>)await _context.Categories.ToListAsync();
            return View(home);
        }

        [HttpPost]
        public async Task<JsonResult> addToCart(int pid, int quantity = 1) {
            string[] toreturn = new string[4] { "error", 0+"", "There was an error.", 0.00+""};
            // 0 = success/error, 1 = total on cart, 2 = html code, 3 = total
            Products product = await _context.Products.Include(p => p.Photos).FirstOrDefaultAsync(p => p.productId == pid);
            if (product != null && product.productStock > 0) {
                product.productQuanitity = quantity;
                if(product.productDiscount > 0) {
                    product.productPrice = Math.Round(product.productPrice * (1 - ((double)product.productDiscount / 100)), 1);
                }
                if(quantity > 1){
                    product.productPriceTotal = Math.Round(product.productPrice * quantity, 1);
                }else {
                    product.productPriceTotal = product.productPrice;
                }
                List<Products> _sessionList = Sessions.GetObjectFromJson<List<Products>>(HttpContext.Session, "cart");
                if (_sessionList == null) {
                    _sessionList = new List<Products>();
                }

                if(!containsProduct(pid, _sessionList)) {
                    _sessionList.Add(product);
                    Sessions.SetObjectAsJson(HttpContext.Session, "cart", _sessionList);
                    toreturn[0] = "success";
                    toreturn[1] = Sessions.returnCount(HttpContext.Session) + "";
                    List<Products> product1 = new List<Products>();
                    product1.Add(product);
                    toreturn[2] = cart.createCart(product1);
                    toreturn[3] = cartTotal(Sessions.returnCount(HttpContext.Session), product.productPriceTotal) + "";
                } else{
                    toreturn[2] = "Product already exists in cart.";
                }
            }else {
                toreturn[2] = "Could't add product to cart, we are out of stock.";
            }
            return Json(toreturn);
        }

        [HttpPost]
        public async Task<JsonResult> removeFromCart(int pid) {
            string[] toreturn = new string[3] { "error", 0.00 + "", 0 + "" };
            Products product = await _context.Products.Include(p => p.Photos).FirstOrDefaultAsync(p => p.productId == pid);
            if (product != null) {
                List<Products> _sessionList = Sessions.GetObjectFromJson<List<Products>>(HttpContext.Session, "cart");
                int i = 0;
                for (i = 0; i < _sessionList.Count(); i++){
                    if (_sessionList.ElementAt(i).productId == pid) {
                        break;
                    }
                }
                var cmimi = _sessionList.ElementAt(i).productPriceTotal;
                _sessionList.RemoveAt(i);
                Sessions.SetObjectAsJson(HttpContext.Session, "cart", _sessionList);
                toreturn[0] = "success";
                toreturn[2] = Sessions.returnCount(HttpContext.Session) + "";
                double totalAfterDelete = 0;
                if (_sessionList.Count() <= 0) {
                    toreturn[1] = 0+"";
                    totalAfterDelete = 0;
                } else {
                    totalAfterDelete = Math.Round(Sessions.GetObjectFromJson<double>(HttpContext.Session, "cart_total") - cmimi, 1);
                    toreturn[1] = totalAfterDelete+"";
                }
                Sessions.SetObjectAsJson(HttpContext.Session, "cart_total", totalAfterDelete);
            }
            return Json(toreturn);
        }

        public bool containsProduct(int pid, List<Products> list){
            if (list == null || list.Count() <= 0){
                return false;
            }
            foreach (var exists in list){
                if (pid == exists.productId) {
                    return true;
                }
            }
            return false;
        }

        public double cartTotal(int count, double productPrice) {
            var total = productPrice;
            if (count != 1) {
                total += Sessions.GetObjectFromJson<double>(HttpContext.Session, "cart_total");
            }
            Sessions.SetObjectAsJson(HttpContext.Session, "cart_total", total);
            return total;
        }
    }
}
