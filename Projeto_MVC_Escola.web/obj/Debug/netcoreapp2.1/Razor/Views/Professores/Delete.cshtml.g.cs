#pragma checksum "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9ee0d29cb2c464f354fad58174ec38c25fb7774"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professores_Delete), @"mvc.1.0.view", @"/Views/Professores/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Professores/Delete.cshtml", typeof(AspNetCore.Views_Professores_Delete))]
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
#line 1 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\_ViewImports.cshtml"
using Projeto_MVC_Escola.web;

#line default
#line hidden
#line 2 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\_ViewImports.cshtml"
using Projeto_MVC_Escola.web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9ee0d29cb2c464f354fad58174ec38c25fb7774", @"/Views/Professores/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07d28745cde45923c82041a726d1169ccad201e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Professores_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projeto_MVC_Escola.web.Models.ProfessorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 179, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ProfessorViewModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(328, 40, false);
#line 16 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(368, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(412, 36, false);
#line 19 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(448, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(492, 42, false);
#line 22 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.genero));

#line default
#line hidden
            EndContext();
            BeginContext(534, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(578, 38, false);
#line 25 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.genero));

#line default
#line hidden
            EndContext();
            BeginContext(616, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(660, 38, false);
#line 28 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.cc));

#line default
#line hidden
            EndContext();
            BeginContext(698, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(742, 34, false);
#line 31 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.cc));

#line default
#line hidden
            EndContext();
            BeginContext(776, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(820, 39, false);
#line 34 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.nif));

#line default
#line hidden
            EndContext();
            BeginContext(859, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(903, 35, false);
#line 37 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.nif));

#line default
#line hidden
            EndContext();
            BeginContext(938, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(982, 44, false);
#line 40 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.contacto));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1070, 40, false);
#line 43 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.contacto));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1154, 42, false);
#line 46 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.morada));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1240, 38, false);
#line 49 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.morada));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1322, 46, false);
#line 52 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.localidade));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1412, 42, false);
#line 55 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.localidade));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1498, 40, false);
#line 58 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.cp_1));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1582, 36, false);
#line 61 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.cp_1));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1662, 40, false);
#line 64 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.cp_2));

#line default
#line hidden
            EndContext();
            BeginContext(1702, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1746, 36, false);
#line 67 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.cp_2));

#line default
#line hidden
            EndContext();
            BeginContext(1782, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1826, 44, false);
#line 70 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1870, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1914, 40, false);
#line 73 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1954, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1998, 41, false);
#line 76 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(2039, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2083, 37, false);
#line 79 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(2120, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2158, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0e005ebf6a943869234daecdddf156f", async() => {
                BeginContext(2184, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2194, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "53ca2d61f87547dcaf6e7bc7b32c1aa3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 84 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2230, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2314, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f248bafd5aac45f3b2cd245aba0e0387", async() => {
                    BeginContext(2336, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2352, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2365, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projeto_MVC_Escola.web.Models.ProfessorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
