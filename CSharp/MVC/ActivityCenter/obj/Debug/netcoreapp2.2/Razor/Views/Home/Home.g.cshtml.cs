#pragma checksum "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "480551df03874fdc351dd992696524d5238fb574"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#line 2 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"480551df03874fdc351dd992696524d5238fb574", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 315, true);
            WriteLiteral(@"

<div class=""content"">
    <div class=""header"">
        <br />
        <div class=""row"">
            <div class=""col"">
                <h2>Dojo Activity Center</h2>
            </div>
            <div class=""col""></div>
            <div class=""col text-right"">
                <p style=""display: inline;"">Welcome, ");
            EndContext();
            BeginContext(316, 22, false);
#line 12 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                                                Write(ViewBag.UserLogin.Name);

#line default
#line hidden
            EndContext();
            BeginContext(338, 572, true);
            WriteLiteral(@"   </p>
                <a href=""/"" style=""display: inline; margin-left: 20px"">Logout</a>
            </div>
        </div>
        <hr>
    </div>
    <div class=""detail"">
        <table class=""table table-stripe"">
            <thead>
                <tr>
                    <th>Activity</th>
                    <th>Date and Time</th>
                    <th>Duration</th>
                    <th>Event Coordinator</th>
                    <th>No. of Participants</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 31 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                 foreach( var activity in @ViewBag.AllActivities )
                {

#line default
#line hidden
            BeginContext(995, 55, true);
            WriteLiteral("                    <tr>\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1050, "\"", 1087, 2);
            WriteAttributeValue("", 1057, "/activity/", 1057, 10, true);
#line 34 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 1067, activity.ActivityId, 1067, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1088, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1090, 14, false);
#line 34 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                                                                Write(activity.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1104, 38, true);
            WriteLiteral("</a></td>\n                        <td>");
            EndContext();
            BeginContext(1143, 18, false);
#line 35 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                       Write(activity.StartTime);

#line default
#line hidden
            EndContext();
            BeginContext(1161, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1196, 17, false);
#line 36 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                       Write(activity.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(1213, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1215, 21, false);
#line 36 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                                          Write(activity.TypeDuration);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 37 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                         foreach( var user in ViewBag.AllUsers )
                        {
                            if ( user.UserId == activity.UserId )
                            {

#line default
#line hidden
            BeginContext(1429, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(1466, 9, false);
#line 41 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                               Write(user.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1475, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 42 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(1537, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1566, 24, false);
#line 44 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                       Write(activity.UsersJoin.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1590, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 45 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                          
                            if ( activity.UserId == ViewBag.UserLogin.UserId)
                            {

#line default
#line hidden
            BeginContext(1731, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1769, "\"", 1839, 4);
            WriteAttributeValue("", 1776, "/delete/activity/", 1776, 17, true);
#line 48 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 1793, activity.ActivityId, 1793, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 1813, "/", 1813, 1, true);
#line 48 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 1814, ViewBag.UserLogin.UserId, 1814, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1840, 17, true);
            WriteLiteral(">Delete</a></td>\n");
            EndContext();
#line 49 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                            }
                            else
                            {
                                bool check = false;
                                foreach ( var user in activity.UsersJoin )
                                {
                                    if ( user.User.UserId == ViewBag.UserLogin.UserId ) 
                                    {
                                        check = true;
                                    }
                                }
                                if ( check )
                                {

#line default
#line hidden
            BeginContext(2443, 42, true);
            WriteLiteral("                                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2485, "\"", 2554, 4);
            WriteAttributeValue("", 2492, "/leave/activity/", 2492, 16, true);
#line 62 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 2508, activity.ActivityId, 2508, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 2528, "/", 2528, 1, true);
#line 62 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 2529, ViewBag.UserLogin.UserId, 2529, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2555, 16, true);
            WriteLiteral(">Leave</a></td>\n");
            EndContext();
#line 63 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2676, 42, true);
            WriteLiteral("                                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2718, "\"", 2786, 4);
            WriteAttributeValue("", 2725, "/join/activity/", 2725, 15, true);
#line 66 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 2740, activity.ActivityId, 2740, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 2760, "/", 2760, 1, true);
#line 66 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 2761, ViewBag.UserLogin.UserId, 2761, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2787, 15, true);
            WriteLiteral(">Join</a></td>\n");
            EndContext();
#line 67 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                                }
                            }
                        

#line default
#line hidden
            BeginContext(2892, 26, true);
            WriteLiteral("                    </tr>\n");
            EndContext();
#line 71 "/Users/penguin/Documents/bootcamp/CSharp/MVC/ActivityCenter/Views/Home/Home.cshtml"
                }

#line default
#line hidden
            BeginContext(2936, 141, true);
            WriteLiteral("            </tbody>\n        </table>\n        <a href=\"/new\" class=\"btn btn-dark\" style=\"float: right\">Add New Activity</a>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
