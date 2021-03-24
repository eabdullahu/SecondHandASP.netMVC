#pragma checksum "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Shared\shoppingcart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d0adf44b208078808933e1a783c5aae6799a86d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_shoppingcart), @"mvc.1.0.view", @"/Views/Shared/shoppingcart.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\_ViewImports.cshtml"
using SecondHand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\_ViewImports.cshtml"
using SecondHand.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Shared\shoppingcart.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d0adf44b208078808933e1a783c5aae6799a86d", @"/Views/Shared/shoppingcart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12ebc1a33230a7d2e992f68ef935239b898b0d36", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_shoppingcart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SecondHand.Models.Homepage.Homepage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""shopping-overlay""></div>
<div id=""shopping-container"">
    <div class=""heading"">
        <span class=""title"">Cart</span>
        <span class=""indicator-container""><i class=""flaticon-close""></i></span>
    </div>
    <div class=""shopping-products"">
");
#nullable restore
#line 10 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Shared\shoppingcart.cshtml"
           List<Products> sessionList = Sessions.GetObjectFromJson<List<Products>>(Context.Session, "cart");
            if (sessionList != null && sessionList.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Shared\shoppingcart.cshtml"
           Write(Html.Raw(new Cart().createCart(sessionList)));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Shared\shoppingcart.cshtml"
                                                             ;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"shopping-cart-prices\"");
            BeginWriteAttribute("style", " style=\"", 661, "\"", 741, 1);
#nullable restore
#line 16 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Shared\shoppingcart.cshtml"
WriteAttributeValue("", 669, sessionList == null || sessionList.Count() == 0 ? "display:none" : "", 669, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"cart-total\">\r\n                <span>Total:</span>\r\n                <span id=\"cart-total-price\">");
#nullable restore
#line 19 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Shared\shoppingcart.cshtml"
                                        Write(sessionList != null ? Sessions.GetObjectFromJson<double>(Context.Session, "cart_total") : 0.00);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &euro;</span>\r\n            </div>\r\n            <div style=\"height: 30px;\"></div>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1058, "\"", 1097, 1);
#nullable restore
#line 22 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Shared\shoppingcart.cshtml"
WriteAttributeValue("", 1065, Url.Action("Index", "Checkout"), 1065, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"shopping-buttons shopping-checkout\">Checkout</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1170, "\"", 1205, 1);
#nullable restore
#line 23 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Shared\shoppingcart.cshtml"
WriteAttributeValue("", 1177, Url.Action("Index", "Cart"), 1177, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"shopping-buttons shopping-view-cart\">View cart</a>\r\n        </div>\r\n        <div class=\"cart-total cart-empty\" id=\"shopping-cart-empty\"");
            BeginWriteAttribute("style", " style=\"", 1349, "\"", 1429, 1);
#nullable restore
#line 25 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Shared\shoppingcart.cshtml"
WriteAttributeValue("", 1357, sessionList == null || sessionList.Count() == 0 ? "display:flex" : "", 1357, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <span><i class=\"flaticon-shopping-cart\"></i>&nbsp; Your shopping cart is empty.</span>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SecondHand.Models.Homepage.Homepage> Html { get; private set; }
    }
}
#pragma warning restore 1591