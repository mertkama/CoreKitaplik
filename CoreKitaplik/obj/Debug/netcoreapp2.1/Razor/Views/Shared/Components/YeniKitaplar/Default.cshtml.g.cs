#pragma checksum "C:\Users\mert1\source\repos\CoreKitaplik\CoreKitaplik\Views\Shared\Components\YeniKitaplar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ed0c04a6eca017dc7e1bf7cf02ae06bb06eefab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_YeniKitaplar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/YeniKitaplar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/YeniKitaplar/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_YeniKitaplar_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ed0c04a6eca017dc7e1bf7cf02ae06bb06eefab", @"/Views/Shared/Components/YeniKitaplar/Default.cshtml")]
    public class Views_Shared_Components_YeniKitaplar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreKitaplik.Models.Kitaplar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 127, true);
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>AD</th>\r\n        <th>YAZAR</th>\r\n    </tr>\r\n");
            EndContext();
#line 9 "C:\Users\mert1\source\repos\CoreKitaplik\CoreKitaplik\Views\Shared\Components\YeniKitaplar\Default.cshtml"
     foreach(var x in Model)
            {

#line default
#line hidden
            BeginContext(222, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(269, 4, false);
#line 12 "C:\Users\mert1\source\repos\CoreKitaplik\CoreKitaplik\Views\Shared\Components\YeniKitaplar\Default.cshtml"
                   Write(x.ID);

#line default
#line hidden
            EndContext();
            BeginContext(273, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(305, 9, false);
#line 13 "C:\Users\mert1\source\repos\CoreKitaplik\CoreKitaplik\Views\Shared\Components\YeniKitaplar\Default.cshtml"
                   Write(x.KitapAd);

#line default
#line hidden
            EndContext();
            BeginContext(314, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(346, 7, false);
#line 14 "C:\Users\mert1\source\repos\CoreKitaplik\CoreKitaplik\Views\Shared\Components\YeniKitaplar\Default.cshtml"
                   Write(x.Yazar);

#line default
#line hidden
            EndContext();
            BeginContext(353, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 16 "C:\Users\mert1\source\repos\CoreKitaplik\CoreKitaplik\Views\Shared\Components\YeniKitaplar\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(398, 40, true);
            WriteLiteral("</table>\r\n<div>Burası components</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreKitaplik.Models.Kitaplar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
