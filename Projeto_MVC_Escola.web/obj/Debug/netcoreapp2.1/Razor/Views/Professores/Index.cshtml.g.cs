#pragma checksum "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2639aa469d2c37be4fc935d0361375cd99b32e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professores_Index), @"mvc.1.0.view", @"/Views/Professores/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Professores/Index.cshtml", typeof(AspNetCore.Views_Professores_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2639aa469d2c37be4fc935d0361375cd99b32e6", @"/Views/Professores/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07d28745cde45923c82041a726d1169ccad201e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Professores_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Projeto_MVC_Escola.web.Data.Entities.Professor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(158, 63, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n<br />\r\n<p class=\"mt-5\" align=\"center\">\r\n    ");
            EndContext();
            BeginContext(221, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54a0af8102e2456484997a1d9ccbd5c1", async() => {
                BeginContext(268, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(282, 125, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" align=\"center\" style=\"width:85%\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(408, 40, false);
#line 17 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(448, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(504, 42, false);
#line 20 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.genero));

#line default
#line hidden
            EndContext();
            BeginContext(546, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(602, 38, false);
#line 23 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cc));

#line default
#line hidden
            EndContext();
            BeginContext(640, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(696, 39, false);
#line 26 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nif));

#line default
#line hidden
            EndContext();
            BeginContext(735, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(791, 44, false);
#line 29 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.contacto));

#line default
#line hidden
            EndContext();
            BeginContext(835, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(891, 42, false);
#line 32 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.morada));

#line default
#line hidden
            EndContext();
            BeginContext(933, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(989, 46, false);
#line 35 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.localidade));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1091, 40, false);
#line 38 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cp_1));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1187, 40, false);
#line 41 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cp_2));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1283, 44, false);
#line 44 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1383, 41, false);
#line 47 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(1424, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 53 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1559, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1620, 39, false);
#line 57 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
            EndContext();
            BeginContext(1659, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1727, 41, false);
#line 60 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.genero));

#line default
#line hidden
            EndContext();
            BeginContext(1768, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1836, 37, false);
#line 63 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.cc));

#line default
#line hidden
            EndContext();
            BeginContext(1873, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1941, 38, false);
#line 66 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.nif));

#line default
#line hidden
            EndContext();
            BeginContext(1979, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2047, 43, false);
#line 69 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.contacto));

#line default
#line hidden
            EndContext();
            BeginContext(2090, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2158, 41, false);
#line 72 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.morada));

#line default
#line hidden
            EndContext();
            BeginContext(2199, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2267, 45, false);
#line 75 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.localidade));

#line default
#line hidden
            EndContext();
            BeginContext(2312, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2380, 39, false);
#line 78 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.cp_1));

#line default
#line hidden
            EndContext();
            BeginContext(2419, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2487, 39, false);
#line 81 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.cp_2));

#line default
#line hidden
            EndContext();
            BeginContext(2526, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2594, 43, false);
#line 84 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2637, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2705, 40, false);
#line 87 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
            EndContext();
            BeginContext(2745, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2812, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b770488927bc4cdebf55039164ae2167", async() => {
                BeginContext(2857, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2865, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2889, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0fd8944ec854c469c1d357c158c7e25", async() => {
                BeginContext(2937, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2948, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2972, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1baf29e1d3245dba51a41202f12c91f", async() => {
                BeginContext(3019, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3029, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 95 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Professores\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3084, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Projeto_MVC_Escola.web.Data.Entities.Professor>> Html { get; private set; }
    }
}
#pragma warning restore 1591