#pragma checksum "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be06caff55318fc1adda61ba44248f01e87eb7fd"
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
#line 1 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\_ViewImports.cshtml"
using MvcDemo.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\_ViewImports.cshtml"
using MvcDemo.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\_ViewImports.cshtml"
using MvcDemo.PL.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\_ViewImports.cshtml"
using MvcDemo.DAL.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\_ViewImports.cshtml"
using MvcDemo.BLL.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be06caff55318fc1adda61ba44248f01e87eb7fd", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa677d6c76855dae61d5a29c1f74214ab3579253", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsViewPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Users</h1>\r\n<br />\r\n<br />\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be06caff55318fc1adda61ba44248f01e87eb7fd6170", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-sm-8"">
            <input placeholder=""Search By Email"" name=""SearchValue"" class=""form-control"" />

        </div>
        <div class=""col-sm-4"">
            <input type=""submit"" value=""Search"" class=""btn btn-success btn-block"" />
        </div>

    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 26 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
 if (Model?.Count() > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-striped table-hover \">\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 32 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(user=>user.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 33 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(user=>user.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 34 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(user=>user.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 35 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(user=>user.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 36 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(user=>user.IsAgree));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>Details</th>\r\n                <th>Update</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
             foreach (var user in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
                 if (user != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(u=>user.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(u=>user.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(u=>user.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(u=>user.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(u=>user.IsAgree));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "be06caff55318fc1adda61ba44248f01e87eb7fd12516", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 54 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = user.Id.ToString();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 57 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert-danger\" mt-5>\r\n                        <h3>\r\n                            No Users Found\r\n                        </h3>\r\n                    </div>\r\n");
#nullable restore
#line 65 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 69 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"


}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert-danger\" mt-5>\r\n        <h3>\r\n            No Users Found\r\n        </h3>\r\n    </div>\r\n");
#nullable restore
#line 79 "C:\Users\forla\OneDrive\Desktop\Asp Core MVC Assignments\Assignment 02 -\MvcDemo.PL\Views\Users\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
