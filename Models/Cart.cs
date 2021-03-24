using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Models
{
    public class Cart {

        public string createCart(List<Products> products)
        {
            string created = null;
            foreach (var product in products)
            {
                created += "" +
                "<div class='shopping-single-product' p-id='" + product.productId + "'> " +
                    "<span class='remove-product' aria-label='Remove from cart' data-microtip-position='left' role='tooltip'><i class='flaticon-close'></i></span> " +
                    "<a href='/Products/Details/" + product.productId + "'>" +
                        "<img src = '/images/products/" + product.Photos.ElementAt(0).photoThumb + "' /> " +
                    "</a>" +
                    "<div class='name-content'> " +
                        "<a href='/Products/Details/" + product.productId + "'>" +
                            "<span class='shopping-name'>" + product.productTitle + "</span> " +
                            "<p> " +
                                "<span class='cart-count'>" + product.productQuanitity + " x</span> " +
                                "<span class='product-price'>" + product.productPrice + " &euro;</span> " +
                            "</p> " +
                        "</a>" +
                    "</div> " +
                "</div> ";
            }
            return created;
        }
    }
}
