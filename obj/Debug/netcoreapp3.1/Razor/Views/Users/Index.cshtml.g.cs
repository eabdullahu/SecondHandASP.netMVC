#pragma checksum "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7f0a0c19a445c82354f36404d12d9d732c1a55f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7f0a0c19a445c82354f36404d12d9d732c1a55f", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12ebc1a33230a7d2e992f68ef935239b898b0d36", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SecondHand.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input width100 outline-badge-blue shadow costumeBackLink"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["Title"] = "Index";
    var SearchedString = ViewData["search"] != null ? (string)ViewData["search"] : "";


    //var itemToShow = (int)ViewData["itemToShow"];
    var totalRows = (int)ViewData["totalPage"];
    var totalPages = (int)ViewData["totalPages"];
    var pageIndex = (int)ViewData["pageIndex"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container m-t-20\">\r\n    <div class=\"form-content\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f0a0c19a445c82354f36404d12d9d732c1a55f5900", async() => {
                WriteLiteral("\r\n            <div class=\"search d-flex\">\r\n                <div>\r\n                    <input name=\"search\" placeholder=\"What are you looking for...\"");
                BeginWriteAttribute("value", " value=\"", 662, "\"", 685, 1);
#nullable restore
#line 20 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
WriteAttributeValue("", 670, SearchedString, 670, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    <button type=""submit""><i class=""fas fa-search""></i>&nbsp;Search</button>
                    <button class=""reset-filer""><i class=""fas fa-filter""></i></button>
                </div>
                <div class=""open-search-filter""> <i class=""fas fa-chevron-circle-down""></i>&nbsp;More Options</div>
            </div>
            <div class=""other-filters "">
                <div class=""search d-flex w-100"">
                    <span>
                        <label for=""start_date"">Added Date</label>
                        <input name=""start_date"" id=""startdate"" placeholder=""What are you looking for..."" type=""date"">
                    </span>
                    <span>
                        <label for=""end_date"">Added upto     Date</label>
                        <input name=""end_date"" placeholder=""What are you looking for..."" type=""date"">
                    </span>
                    <span>
                        <label for=""UserRoles"">Role</label>
                ");
                WriteLiteral("        ");
#nullable restore
#line 38 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
                   Write(Html.DropDownList("selectUsersbyRole", (IEnumerable<SelectListItem>)ViewData["UserRolesData"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>


<div class=""container m-t-20"">
    <div class=""responsiveTable"">
        
            <div class=""d-flex"">
                <div class=""inputContainer justify-content-end m-t-20"" style="" width: 160px !important;"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f0a0c19a445c82354f36404d12d9d732c1a55f9707", async() => {
                WriteLiteral("Create User");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <table class=""m-t-20"">
                <thead>
                    <tr>
                        <th class=""text-center"">Name</th>
                        <th>Surname</th>
                        <th>Email</th>
                        <th>added date</th>

                        <th class=""text-center"">Actions</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 67 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 72 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserFirstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 75 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserLastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 78 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 82 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserRegisterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f0a0c19a445c82354f36404d12d9d732c1a55f13287", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f0a0c19a445c82354f36404d12d9d732c1a55f15473", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 89 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n        <div class=\"d-flex justify-content-end\">\r\n");
#nullable restore
#line 95 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
             if (pageIndex - 1 > 0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"viewMore pagination-buttons\"");
            BeginWriteAttribute("href", " href=\"", 3987, "\"", 4014, 2);
            WriteAttributeValue("", 3994, "?page=", 3994, 6, true);
#nullable restore
#line 98 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
WriteAttributeValue("", 4000, pageIndex-1, 4000, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> &lt; </a>\r\n");
#nullable restore
#line 99 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
             for (var i = Math.Max(1, pageIndex - 2); i <= Math.Min(pageIndex + 2, totalPages); i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"viewMore pagination-buttons\"");
            BeginWriteAttribute("href", " href=\"", 4214, "\"", 4229, 2);
            WriteAttributeValue("", 4221, "?page=", 4221, 6, true);
#nullable restore
#line 102 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
WriteAttributeValue("", 4227, i, 4227, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 102 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 103 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
             if (pageIndex + 1 <= totalPages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"viewMore pagination-buttons\"");
            BeginWriteAttribute("href", " href=\"", 4370, "\"", 4397, 2);
            WriteAttributeValue("", 4377, "?page=", 4377, 6, true);
#nullable restore
#line 106 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
WriteAttributeValue("", 4383, pageIndex+1, 4383, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> &gt;</a>\r\n");
#nullable restore
#line 107 "C:\Users\enisa\Desktop\ThredPlus\ThredPlus\Views\Users\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SecondHand.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
