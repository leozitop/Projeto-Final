#pragma checksum "C:\Users\45684686800\Documents\Projeto Final\Projeto-Final\Views\Shared\_HeaderNavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0cb00d8d5cef39bfe1ee6b1a13a447e9d5e19ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderNavBar), @"mvc.1.0.view", @"/Views/Shared/_HeaderNavBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_HeaderNavBar.cshtml", typeof(AspNetCore.Views_Shared__HeaderNavBar))]
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
#line 1 "C:\Users\45684686800\Documents\Projeto Final\Projeto-Final\Views\_ViewImports.cshtml"
using Projeto_Final;

#line default
#line hidden
#line 2 "C:\Users\45684686800\Documents\Projeto Final\Projeto-Final\Views\_ViewImports.cshtml"
using Projeto_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0cb00d8d5cef39bfe1ee6b1a13a447e9d5e19ad", @"/Views/Shared/_HeaderNavBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0f11c877b8160f2778780b62b0cbf6e0796ec9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HeaderNavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 78, true);
            WriteLiteral("\r\n<nav>\r\n    <div class=\"section-container\">\r\n        <ul>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 78, "\'", 126, 2);
#line 5 "C:\Users\45684686800\Documents\Projeto Final\Projeto-Final\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 85, Url.Action("Index", "Home"), 85, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 113, "\"#quem_somos\"", 113, 13, true);
            EndWriteAttribute();
            BeginContext(127, 36, true);
            WriteLiteral(">Active</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 163, "\'", 209, 2);
#line 6 "C:\Users\45684686800\Documents\Projeto Final\Projeto-Final\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 170, Url.Action("Index", "Home"), 170, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 198, "\"#historia\"", 198, 11, true);
            EndWriteAttribute();
            BeginContext(210, 34, true);
            WriteLiteral(">Link</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 244, "\'", 288, 2);
#line 7 "C:\Users\45684686800\Documents\Projeto Final\Projeto-Final\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 251, Url.Action("Index", "Home"), 251, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 279, "\"#planos\"", 279, 9, true);
            EndWriteAttribute();
            BeginContext(289, 34, true);
            WriteLiteral(">Link</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 323, "\'", 367, 2);
#line 8 "C:\Users\45684686800\Documents\Projeto Final\Projeto-Final\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 330, Url.Action("Index", "Home"), 330, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 358, "\"#equipe\"", 358, 9, true);
            EndWriteAttribute();
            BeginContext(368, 38, true);
            WriteLiteral(">Disabled</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 406, "\'", 449, 2);
#line 9 "C:\Users\45684686800\Documents\Projeto Final\Projeto-Final\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 413, Url.Action("Index", "Home"), 413, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 441, "\"#local\"", 441, 8, true);
            EndWriteAttribute();
            BeginContext(450, 45, true);
            WriteLiteral("></a></li>\r\n        </ul>\r\n    </div>\r\n</nav>");
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
