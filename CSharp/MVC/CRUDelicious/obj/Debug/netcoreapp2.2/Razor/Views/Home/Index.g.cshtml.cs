#pragma checksum "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b1dd6dcd844a6deea938c94ab73f8a5282add6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b1dd6dcd844a6deea938c94ab73f8a5282add6b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(64, 327, true);
            WriteLiteral(@"
<div class=""content"">
    <br /><br /><br />
    <div class=""header"" style=""text-align: center"">
        <h1>Welcome to CRUDelicious</h1>
    </div>
    <br /><br />
    <div class=""row"">
        <div class=""col""></div>
        <div class=""col-5"">
            <p>Check out some recent dishes!</p>
            <hr>
");
            EndContext();
#line 17 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Index.cshtml"
             foreach ( var info in Model)
            {

#line default
#line hidden
            BeginContext(449, 21, true);
            WriteLiteral("                <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 470, "\"", 489, 1);
#line 19 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Index.cshtml"
WriteAttributeValue("", 477, info.DishId, 477, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(490, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(492, 9, false);
#line 19 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Index.cshtml"
                                     Write(info.Name);

#line default
#line hidden
            EndContext();
            BeginContext(501, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(510, 9, false);
#line 19 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Index.cshtml"
                                                       Write(info.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(519, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 20 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(540, 206, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-3\">\r\n            <a href=\"new\" class=\"btn btn-outline-info\" style=\"float: right\">Add a Dish</a>\r\n        </div>\r\n        <div class=\"col\"></div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
