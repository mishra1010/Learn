#pragma checksum "C:\Projects\EmpManagement\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5bfe5c1a6f62836c1ce342a15554e6634b72c9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5bfe5c1a6f62836c1ce342a15554e6634b72c9f", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmpManagement.ViewModels.HomeDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 10, true);
            WriteLiteral("\r\n    <h3>");
            EndContext();
            BeginContext(65, 15, false);
#line 3 "C:\Projects\EmpManagement\Views\Home\Details.cshtml"
   Write(Model.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(80, 39, true);
            WriteLiteral("</h3>\r\n\r\n   \r\n    <div>\r\n        Name: ");
            EndContext();
            BeginContext(120, 19, false);
#line 7 "C:\Projects\EmpManagement\Views\Home\Details.cshtml"
         Write(Model.Employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(139, 39, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Name: ");
            EndContext();
            BeginContext(179, 20, false);
#line 10 "C:\Projects\EmpManagement\Views\Home\Details.cshtml"
         Write(Model.Employee.Email);

#line default
#line hidden
            EndContext();
            BeginContext(199, 39, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Name: ");
            EndContext();
            BeginContext(239, 25, false);
#line 13 "C:\Projects\EmpManagement\Views\Home\Details.cshtml"
         Write(Model.Employee.Department);

#line default
#line hidden
            EndContext();
            BeginContext(264, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmpManagement.ViewModels.HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
