#pragma checksum "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a310c114de5a87e42fa85e4d23158d78ae0c0be3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_ForgotPasswordConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
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
#line 1 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Areas\Identity\Pages\_ViewImports.cshtml"
using SecondHand.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Areas\Identity\Pages\_ViewImports.cshtml"
using SecondHand.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Areas\Identity\Pages\_ViewImports.cshtml"
using SecondHand.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using SecondHand.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a310c114de5a87e42fa85e4d23158d78ae0c0be3", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b78553a3bdef891fd0ada79bd9b6e0a49f2c783", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"277957756154fd1f61a064f3f7fe8cad08f83549", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Forgot password confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""mt-0 bck-account page-banner"">
    <div id=""content"">
        <h2 class=""title"">Back to shooping place</h2>
        <ul class=""breadcrumb-list"">
            <li><a href=""javascript:void(0)"">Home</a></li>
            <li><a href=""javascript:void(0)"">");
#nullable restore
#line 12 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
                                        Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"main-container\">\r\n    <div class=\"loginForgetPassword\">\r\n        <div class=\"login_start\">\r\n            <p>");
#nullable restore
#line 20 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"login_form frg-password\">\r\n                <p>\r\n                    Please check your email to reset your password!\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForgotPasswordConfirmation> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation>)PageContext?.ViewData;
        public ForgotPasswordConfirmation Model => ViewData.Model;
    }
}
#pragma warning restore 1591
