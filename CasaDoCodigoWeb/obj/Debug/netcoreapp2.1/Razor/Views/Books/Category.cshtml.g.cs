#pragma checksum "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af15fedf4f0bad7fb48c8b24e8c39e7701b1c90c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Category), @"mvc.1.0.view", @"/Views/Books/Category.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Category.cshtml", typeof(AspNetCore.Views_Books_Category))]
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
#line 1 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\_ViewImports.cshtml"
using CasaDoCodigoWeb;

#line default
#line hidden
#line 2 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\_ViewImports.cshtml"
using CasaDoCodigoWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af15fedf4f0bad7fb48c8b24e8c39e7701b1c90c", @"/Views/Books/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c023d360aa0858766d68318b5f4306ee70b383b", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BooksCategoryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("livroNaVitrine-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
  
    ViewData["Title"] = "Category";

#line default
#line hidden
            BeginContext(75, 291, true);
            WriteLiteral(@"
<header class=""cabecalhoDaColecao"" id=""colecao-livros-de-business"">
    <img src=""//cdn.shopify.com/s/files/1/0155/7645/t/232/assets/icon-business-branco.svg?154916844045550827"" alt="""" class=""cabecalhoDaColecao-icone"">
    <h1 class=""cabecalhoDaColecao-titulo"" itemprop=""name"">Livros de ");
            EndContext();
            BeginContext(367, 18, false);
#line 8 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
                                                               Write(Model.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(385, 20, true);
            WriteLiteral("</h1>\r\n</header>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
 foreach (var item in Model.Items)
{

#line default
#line hidden
            BeginContext(444, 94, true);
            WriteLiteral("    <h2 class=\"vitrineDaColecao-titulo vitrineDaColecao-titulo--business container\">Livros de ");
            EndContext();
            BeginContext(539, 18, false);
#line 13 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
                                                                                         Write(Model.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(557, 9, true);
            WriteLiteral(" <span>/ ");
            EndContext();
            BeginContext(567, 8, false);
#line 13 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
                                                                                                                     Write(item.Key);

#line default
#line hidden
            EndContext();
            BeginContext(575, 110, true);
            WriteLiteral(" </span></h2>\r\n    <section class=\"vitrineDaColecao container\">\r\n        <ul class=\"vitrineDaColecao-lista\">\r\n");
            EndContext();
#line 16 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
             foreach (var book in item.Value)
            {

#line default
#line hidden
            BeginContext(747, 90, true);
            WriteLiteral("                <li class=\"livroNaVitrine vitrineDaColecao-produto\">\r\n                    ");
            EndContext();
            BeginContext(837, 544, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1a85d9097b24e009c83db38efe44044", async() => {
                BeginContext(956, 155, true);
                WriteLiteral("\r\n                        <div class=\"livroNaVitrine-imagemContainer\" role=\"presentation\">\r\n                            <img class=\"livroNaVitrine-imagem \"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1111, "\"", 1131, 1);
#line 21 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
WriteAttributeValue("", 1117, book.CoverUri, 1117, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1132, "\"", 1155, 1);
#line 21 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
WriteAttributeValue("", 1138, book.DisplayName, 1138, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1156, "\"", 1181, 1);
#line 21 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
WriteAttributeValue("", 1164, book.DisplayName, 1164, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1182, 123, true);
                WriteLiteral(">\r\n                        </div>\r\n                        <span class=\"livroNaVitrine-nome\">\r\n                            ");
                EndContext();
                BeginContext(1306, 16, false);
#line 24 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
                       Write(book.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(1322, 55, true);
                WriteLiteral("\r\n                        </span>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
                                                                     WriteLiteral(book.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
AddHtmlAttributeValue("", 943, book.Title, 943, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1381, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 28 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
            }

#line default
#line hidden
            BeginContext(1421, 31, true);
            WriteLiteral("        </ul>\r\n    </section>\r\n");
            EndContext();
#line 31 "C:\Users\User\Documents\Cursos\Azure\CodigoFonte\CasaDoCodigoWeb\Views\Books\Category.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BooksCategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
