#pragma checksum "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Areas\Identity\Pages\Account\Manage\_AccountOverview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af0d2e2b267e1072331dee5963a2f6fa49396c60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage__AccountOverview), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_AccountOverview.cshtml")]
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
#nullable restore
#line 1 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using SecondHand.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af0d2e2b267e1072331dee5963a2f6fa49396c60", @"/Areas/Identity/Pages/Account/Manage/_AccountOverview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b78553a3bdef891fd0ada79bd9b6e0a49f2c783", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"277957756154fd1f61a064f3f7fe8cad08f83549", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7acdf964293996a6ca8b9123d49c287ea1593f6b", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__AccountOverview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Areas\Identity\Pages\Account\Manage\_AccountOverview.cshtml"
  
    var hasExternalLogins = (await SignInManager.GetExternalAuthenticationSchemesAsync()).Any();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""account_overview toogle_profile"">
    <p>welcome to </p>
    <p> your account</p>
</div>
<div class=""user-dashboard toogle_profile"" style=""display:none;"">
    <h3>Dashboard</h3>
    <p>Executive Sales Summary</p>
    <div class=""statistics-user"">
        <div id=""columnchart_values"" style=""width: 90%;""></div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591