#pragma checksum "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dca629bfa3371a04da644308465e639be60659b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Show.cshtml", typeof(AspNetCore.Views_Home_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dca629bfa3371a04da644308465e639be60659b", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 248, true);
            WriteLiteral("\n<div class=\"content\">\n    <br /><br /><br />\n    <div class=\"row\">\n        <div class=\"col\">\n            <a href=\"/\" class=\"btn btn-outline-info btn-sm\">Home</a>\n        </div>\n        <div class=\"col\" style=\"text-align: center;\">\n            <h1>");
            EndContext();
            BeginContext(261, 10, false);
#line 10 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Show.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(271, 22, true);
            WriteLiteral("</h1>\n            <h3>");
            EndContext();
            BeginContext(294, 10, false);
#line 11 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Show.cshtml"
           Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(304, 187, true);
            WriteLiteral("</h3>\n            <hr>\n        </div>\n        <div class=\"col\"></div>\n    </div>\n    <br />\n    <div class=\"row\">\n        <div class=\"col\"></div>\n        <div class=\"col\">\n            <p>");
            EndContext();
            BeginContext(492, 17, false);
#line 20 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Show.cshtml"
          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(509, 37, true);
            WriteLiteral("</p>\n            <p><b>Calories:</b> ");
            EndContext();
            BeginContext(547, 14, false);
#line 21 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Show.cshtml"
                           Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(561, 37, true);
            WriteLiteral("</p>\n            <p><b>Tasiness:</b> ");
            EndContext();
            BeginContext(599, 15, false);
#line 22 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Show.cshtml"
                           Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(614, 202, true);
            WriteLiteral("</p>\n        </div>\n        <div class=\"col\"></div>\n    </div>\n    <br /><br />\n    <div class=\"row\">\n        <div class=\"col\"></div>\n        <div class=\"col\" style=\"text-align: center;\">\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 816, "\"", 843, 2);
            WriteAttributeValue("", 823, "delete/", 823, 7, true);
#line 30 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Show.cshtml"
WriteAttributeValue("", 830, Model.DishId, 830, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(844, 126, true);
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a>\n        </div>\n        <div class=\"col\" style=\"text-align: center;\">\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 970, "\"", 995, 2);
            WriteAttributeValue("", 977, "edit/", 977, 5, true);
#line 33 "/Users/penguin/Documents/bootcamp/CSharp/MVC/CRUDelicious/Views/Home/Show.cshtml"
WriteAttributeValue("", 982, Model.DishId, 982, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(996, 106, true);
            WriteLiteral(" class=\"btn btn-outline-warning\">Edit</a>\n        </div>\n        <div class=\"col\"></div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
