#pragma checksum "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d0276bc548beceea805478ff8b07ef511dc031e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Disciplinas_Index), @"mvc.1.0.view", @"/Views/Disciplinas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Disciplinas/Index.cshtml", typeof(AspNetCore.Views_Disciplinas_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d0276bc548beceea805478ff8b07ef511dc031e", @"/Views/Disciplinas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07d28745cde45923c82041a726d1169ccad201e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Disciplinas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Projeto_MVC_Escola.web.Data.Entities.Disciplina>>
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
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(159, 63, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n<br />\r\n<p class=\"mt-5\" align=\"center\">\r\n    ");
            EndContext();
            BeginContext(222, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9ac0f99ed264bcfbc05c6dd65e112f7", async() => {
                BeginContext(269, 10, true);
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
            BeginContext(283, 125, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" align=\"center\" style=\"width:85%\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(409, 51, false);
#line 17 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nome_disciplina));

#line default
#line hidden
            EndContext();
            BeginContext(460, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(516, 49, false);
#line 20 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.area_formação));

#line default
#line hidden
            EndContext();
            BeginContext(565, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(621, 59, false);
#line 23 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.carga_horaria_discplina));

#line default
#line hidden
            EndContext();
            BeginContext(680, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(736, 54, false);
#line 26 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.creditos_discplina));

#line default
#line hidden
            EndContext();
            BeginContext(790, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(846, 44, false);
#line 29 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id_curso));

#line default
#line hidden
            EndContext();
            BeginContext(890, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(946, 48, false);
#line 32 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id_professor));

#line default
#line hidden
            EndContext();
            BeginContext(994, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1129, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1190, 50, false);
#line 42 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.nome_disciplina));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1308, 48, false);
#line 45 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.area_formação));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1424, 58, false);
#line 48 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.carga_horaria_discplina));

#line default
#line hidden
            EndContext();
            BeginContext(1482, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1550, 53, false);
#line 51 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.creditos_discplina));

#line default
#line hidden
            EndContext();
            BeginContext(1603, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1671, 51, false);
#line 54 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Curso.nome_curso));

#line default
#line hidden
            EndContext();
            BeginContext(1722, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1790, 49, false);
#line 57 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Professor.nome));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1906, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "182e06fcb65149678b98d1c08d274653", async() => {
                BeginContext(1951, 4, true);
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
#line 60 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
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
            BeginContext(1959, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1983, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bff18ab995ce4700bfc778c180142b93", async() => {
                BeginContext(2031, 7, true);
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
#line 61 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
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
            BeginContext(2042, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2066, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d229d2eee98e4b8b9395a5fd4f3a39d2", async() => {
                BeginContext(2113, 6, true);
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
#line 62 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
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
            BeginContext(2123, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 65 "C:\Users\João Silva\Desktop\PROJETO MVC\Projeto_MVC_Escola\Projeto_MVC_Escola.web\Views\Disciplinas\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2178, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Projeto_MVC_Escola.web.Data.Entities.Disciplina>> Html { get; private set; }
    }
}
#pragma warning restore 1591
