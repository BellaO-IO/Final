#pragma checksum "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\Apps\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d5a48ce5f601dfe4da4f11a174caac90864902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Apps_Index), @"mvc.1.0.view", @"/Views/Apps/Index.cshtml")]
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
#line 1 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\_ViewImports.cshtml"
using FixedFinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\_ViewImports.cshtml"
using FixedFinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d5a48ce5f601dfe4da4f11a174caac90864902", @"/Views/Apps/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d67c6fe8d4cb7b0272e3ebf44554ce9d5568a50", @"/Views/_ViewImports.cshtml")]
    public class Views_Apps_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Root>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""table table-striped table-dark pagination-lg"">
    <thead class=""thead-light"">
        <tr>
            <th>rank</th>
            <th>title</th>
            <th>Price</th>
            <th>rating_count</th>
            <th>release_date</th>
            <th>publisher</th>
            <th>rating</th>
            <th>in_app_purchases</th>
            <th>image</th>
        </tr>
    </thead>

");
#nullable restore
#line 17 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\Apps\Index.cshtml"
     foreach (var app in Model.topChart)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td style=\"color: black\">");
#nullable restore
#line 20 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\Apps\Index.cshtml"
                        Write(app.rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 544, "\"", 571, 1);
#nullable restore
#line 21 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\Apps\Index.cshtml"
WriteAttributeValue("", 551, app.apple_store_url, 551, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\Apps\Index.cshtml"
                                  Write(app.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n    <td style=\"color: black\">");
#nullable restore
#line 22 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\Apps\Index.cshtml"
                        Write(app.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td style=\"color: black\">");
#nullable restore
#line 23 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\Apps\Index.cshtml"
                        Write(app.rating_count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td style=\"color: black\">");
#nullable restore
#line 24 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\Apps\Index.cshtml"
                        Write(app.release_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td style=\"color: black\">");
#nullable restore
#line 25 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\Apps\Index.cshtml"
                        Write(app.publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td style=\"color: black\">");
#nullable restore
#line 26 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\Apps\Index.cshtml"
                        Write(app.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td style=\"color: black\">");
#nullable restore
#line 27 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\Apps\Index.cshtml"
                        Write(app.in_app_purchases);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><img");
            BeginWriteAttribute("src", " src=\"", 912, "\"", 931, 1);
#nullable restore
#line 28 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\Apps\Index.cshtml"
WriteAttributeValue("", 918, app.icon_url, 918, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n\r\n\r\n</tr>\r\n");
#nullable restore
#line 32 "C:\Users\Bella\source\repos\FinalThing\FixedFinalProject\Views\Apps\Index.cshtml"
        
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n\r\n<h1>\r\n\r\n</h1>\r\n\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Root> Html { get; private set; }
    }
}
#pragma warning restore 1591
