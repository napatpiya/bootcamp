#pragma checksum "/Users/penguin/Documents/bootcamp/CSharp/MVC/ViewModelFun/Views/Home/Names.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4672c356ead0b2525d65f2d8da9c33a81e249dc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Names), @"mvc.1.0.view", @"/Views/Home/Names.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Names.cshtml", typeof(AspNetCore.Views_Home_Names))]
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
#line 1 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 2 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4672c356ead0b2525d65f2d8da9c33a81e249dc5", @"/Views/Home/Names.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Names : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 79, true);
            WriteLiteral("\n<div class=\"container\" style=\"text-align: center\">\n<h2>Here is a Users!</h2>\n\n");
            EndContext();
#line 6 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ViewModelFun/Views/Home/Names.cshtml"
 foreach(var name in Model)
{

#line default
#line hidden
            BeginContext(129, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(137, 14, false);
#line 8 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ViewModelFun/Views/Home/Names.cshtml"
  Write(name.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(151, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(153, 13, false);
#line 8 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ViewModelFun/Views/Home/Names.cshtml"
                  Write(name.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(166, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 9 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ViewModelFun/Views/Home/Names.cshtml"
}

#line default
#line hidden
            BeginContext(173, 8, true);
            WriteLiteral("</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
