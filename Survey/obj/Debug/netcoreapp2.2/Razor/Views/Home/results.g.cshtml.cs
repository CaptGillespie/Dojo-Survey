#pragma checksum "/Users/seangillespie/Desktop/Survey/Views/Home/results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "757c104b7317c254015491ca3f8fa9fee57101d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_results), @"mvc.1.0.view", @"/Views/Home/results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/results.cshtml", typeof(AspNetCore.Views_Home_results))]
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
#line 1 "/Users/seangillespie/Desktop/Survey/Views/_ViewImports.cshtml"
using Survey;

#line default
#line hidden
#line 2 "/Users/seangillespie/Desktop/Survey/Views/_ViewImports.cshtml"
using Survey.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"757c104b7317c254015491ca3f8fa9fee57101d4", @"/Views/Home/results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ca22d04279975cf66881929195da49b57ca387", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/seangillespie/Desktop/Survey/Views/Home/results.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 124, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Dojo Survey</h1>\n    <div class = \"survey_box\">\n        <h3>Your Name: ");
            EndContext();
            BeginContext(167, 12, false);
#line 8 "/Users/seangillespie/Desktop/Survey/Views/Home/results.cshtml"
                  Write(ViewBag.name);

#line default
#line hidden
            EndContext();
            BeginContext(179, 54, true);
            WriteLiteral(" <input type =\"text\"></h3>\n        <h3>Dojo Location: ");
            EndContext();
            BeginContext(234, 16, false);
#line 9 "/Users/seangillespie/Desktop/Survey/Views/Home/results.cshtml"
                      Write(ViewBag.location);

#line default
#line hidden
            EndContext();
            BeginContext(250, 36, true);
            WriteLiteral("</h3>\n        <h3>Favorite Language:");
            EndContext();
            BeginContext(287, 16, false);
#line 10 "/Users/seangillespie/Desktop/Survey/Views/Home/results.cshtml"
                         Write(ViewBag.language);

#line default
#line hidden
            EndContext();
            BeginContext(303, 37, true);
            WriteLiteral("</h3>\n        <h3>Comment (optional):");
            EndContext();
            BeginContext(341, 16, false);
#line 11 "/Users/seangillespie/Desktop/Survey/Views/Home/results.cshtml"
                          Write(ViewBag.textarea);

#line default
#line hidden
            EndContext();
            BeginContext(357, 392, true);
            WriteLiteral(@"</h3>
        <button action=""/"" class=""Submit"" type=""Submit"" value=""Go Back"">Go Back</button>

    </div>
</div>

<style>
.survey_box{
    outline: 2px solid black;
    height: 400px;
    padding: 10px;
}
.comment{
    width: 500px;
    height: 150px;
    outline: 2px solid black;
}
.Submit{
    background-color: blue;
    color: white;
    margin-left: 400px;
    width: 100px;
}
</style>");
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
