#pragma checksum "C:\Source\MAC_ASPNET_CORE\MODULO02\ViewComponentDemo\ViewComponentDemo\Views\Shared\Components\Lista\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "129e95b3ea291f13f6b6c341232946c9e07f18b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Lista_Lista), @"mvc.1.0.view", @"/Views/Shared/Components/Lista/Lista.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Lista/Lista.cshtml", typeof(AspNetCore.Views_Shared_Components_Lista_Lista))]
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
#line 1 "C:\Source\MAC_ASPNET_CORE\MODULO02\ViewComponentDemo\ViewComponentDemo\Views\_ViewImports.cshtml"
using ViewComponentDemo;

#line default
#line hidden
#line 2 "C:\Source\MAC_ASPNET_CORE\MODULO02\ViewComponentDemo\ViewComponentDemo\Views\_ViewImports.cshtml"
using ViewComponentDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129e95b3ea291f13f6b6c341232946c9e07f18b3", @"/Views/Shared/Components/Lista/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb935a215ce4d0dba59f000b05b3a6fa8b432401", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Lista_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 64, true);
            WriteLiteral("\r\n<style type=\"text/css\">\r\n    li{font-size: 20px}\r\n</style>\r\n\r\n");
            EndContext();
#line 7 "C:\Source\MAC_ASPNET_CORE\MODULO02\ViewComponentDemo\ViewComponentDemo\Views\Shared\Components\Lista\Lista.cshtml"
 if(ViewData["Titulo"] != null)
{

#line default
#line hidden
            BeginContext(128, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(137, 18, false);
#line 9 "C:\Source\MAC_ASPNET_CORE\MODULO02\ViewComponentDemo\ViewComponentDemo\Views\Shared\Components\Lista\Lista.cshtml"
   Write(ViewData["Titulo"]);

#line default
#line hidden
            EndContext();
            BeginContext(155, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 10 "C:\Source\MAC_ASPNET_CORE\MODULO02\ViewComponentDemo\ViewComponentDemo\Views\Shared\Components\Lista\Lista.cshtml"
}

#line default
#line hidden
            BeginContext(165, 8, true);
            WriteLiteral("\r\n<ul>\r\n");
            EndContext();
#line 13 "C:\Source\MAC_ASPNET_CORE\MODULO02\ViewComponentDemo\ViewComponentDemo\Views\Shared\Components\Lista\Lista.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
            BeginContext(213, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(226, 4, false);
#line 15 "C:\Source\MAC_ASPNET_CORE\MODULO02\ViewComponentDemo\ViewComponentDemo\Views\Shared\Components\Lista\Lista.cshtml"
       Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(230, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 16 "C:\Source\MAC_ASPNET_CORE\MODULO02\ViewComponentDemo\ViewComponentDemo\Views\Shared\Components\Lista\Lista.cshtml"
    }

#line default
#line hidden
            BeginContext(244, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
