#pragma checksum "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57ad24f871701ba4057cf5f13358de64dfa560fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wishlist_Index), @"mvc.1.0.view", @"/Views/Wishlist/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ad24f871701ba4057cf5f13358de64dfa560fe", @"/Views/Wishlist/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12ebc1a33230a7d2e992f68ef935239b898b0d36", @"/Views/_ViewImports.cshtml")]
    public class Views_Wishlist_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SecondHand.Models.Homepage.Homepage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/nav.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/shoppingcart.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "57ad24f871701ba4057cf5f13358de64dfa560fe3939", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"page-banner\">\r\n    <div class=\"main-container\">\r\n        <div id=\"content\">\r\n            <h2 class=\"title\">Wishlist</h2>\r\n            <ul class=\"breadcrumb-list\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 335, "\"", 370, 1);
#nullable restore
#line 14 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
WriteAttributeValue("", 342, Url.Action("Index", "Home"), 342, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a></li>\r\n                <li><a href=\"javascript:void(0)\">Wishlist</a></li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"main-container\">\r\n    <div class=\"products-container\">\r\n        <div class=\"products\">\r\n");
#nullable restore
#line 24 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
             foreach (var product in Model.Hp_Products) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"item\"");
            BeginWriteAttribute("p-id", " p-id=\"", 704, "\"", 729, 1);
#nullable restore
#line 25 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
WriteAttributeValue("", 711, product.productId, 711, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 786, "\"", 859, 1);
#nullable restore
#line 27 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
WriteAttributeValue("", 793, Url.Action("Details", "Products", new { id = product.productId }), 793, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 895, "\"", 956, 2);
            WriteAttributeValue("", 901, "images/products/", 901, 16, true);
#nullable restore
#line 28 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
WriteAttributeValue("", 917, product.Photos.ElementAt(0).photoThumb, 917, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </a>\r\n                        <div class=\"left\">\r\n");
#nullable restore
#line 31 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                             if (product.productStock > 0) {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                                 if (product.productStatus != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"onsale\">");
#nullable restore
#line 32 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                                                                                      Write(product.productStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 32 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                                                                                                                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                                 if (product.productDiscount > 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"onsale\">-");
#nullable restore
#line 33 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                                                                                     Write(Math.Round(product.productDiscount,1));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span> ");
#nullable restore
#line 33 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                                                                                                                                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                                                                                                                                          
                            }else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"soldout\">SOLDOUT</span>\r\n");
#nullable restore
#line 36 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""right"">
                            <button type=""button"" class=""wishlist wishlist-delete"" aria-label=""Remove from wishlist"" data-microtip-position=""left"" role=""tooltip""><i class=""flaticon-close""></i></button>
                        </div>
                    </div>
                    <div class=""content"">
                        <div class=""position-relative"">
                            <h3 class=""title"">");
#nullable restore
#line 44 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                                         Write(product.productTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 45 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                             if (product.productStock > 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" class=\"buy\">+  Add to cart</button>\r\n");
#nullable restore
#line 47 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                            }else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" class=\"buy soldout\">-  Soldout</button>\r\n");
#nullable restore
#line 49 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"price\">\r\n");
#nullable restore
#line 52 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                             if (product.productDiscount > 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
#nullable restore
#line 53 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                                 Write(Math.Round(product.productPrice * (1 - ((double)product.productDiscount / 100)), 1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &euro;</span>\r\n                                <span class=\"discount\">");
#nullable restore
#line 54 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                                                  Write(product.productPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &euro;</span>\r\n");
#nullable restore
#line 55 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                            }else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
#nullable restore
#line 56 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                                 Write(product.productPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &euro;</span>\r\n");
#nullable restore
#line 57 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 61 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"align-center width100\" id=\"wishlistEmpty\"");
            BeginWriteAttribute("style", " style=\"", 3001, "\"", 3065, 1);
#nullable restore
#line 62 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Wishlist\Index.cshtml"
WriteAttributeValue("", 3009, Model.Hp_Products.Count() > 0 ? "display: none;" : "", 3009, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t<a class=\"show-more\" href=\"javascript:void(0)\">Your wishlist is empty.</a>\r\n\t\t\t</div>\r\n        </div>\r\n    </div>\r\n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "57ad24f871701ba4057cf5f13358de64dfa560fe14549", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
