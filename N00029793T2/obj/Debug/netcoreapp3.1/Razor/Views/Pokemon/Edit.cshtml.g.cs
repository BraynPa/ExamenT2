#pragma checksum "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88122c4e3a7ff5646ea7b12132707231065a7db1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemon_Edit), @"mvc.1.0.view", @"/Views/Pokemon/Edit.cshtml")]
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
#line 1 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\_ViewImports.cshtml"
using N00029793T2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\_ViewImports.cshtml"
using N00029793T2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88122c4e3a7ff5646ea7b12132707231065a7db1", @"/Views/Pokemon/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f0f34b3ff249ca0b1f14cac75b8c7d19f0ae67", @"/Views/_ViewImports.cshtml")]
    public class Views_Pokemon_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/account/edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Edit.cshtml"
   
    var pokemon = (Pokemon)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("   \n\n\n<h1>Editar Pokemon</h1>\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88122c4e3a7ff5646ea7b12132707231065a7db14196", async() => {
                WriteLiteral("\n\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 151, "\"", 170, 1);
#nullable restore
#line 12 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Edit.cshtml"
WriteAttributeValue("", 159, pokemon.Id, 159, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    <input type=\"hidden\" name=\"RutaImgPo\"");
                BeginWriteAttribute("value", " value=\"", 216, "\"", 242, 1);
#nullable restore
#line 13 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Edit.cshtml"
WriteAttributeValue("", 224, pokemon.RutaImgPo, 224, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    ");
#nullable restore
#line 14 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Edit.cshtml"
Write(Html.ValidationMessage("RutaImgPo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n<div class=\"form-group\">\n    <label>Nombre</label>\n    <input class=\"form-control\" name=\"Nombre\"");
                BeginWriteAttribute("value", " value=\"", 386, "\"", 409, 1);
#nullable restore
#line 19 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Edit.cshtml"
WriteAttributeValue("", 394, pokemon.Nombre, 394, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    ");
#nullable restore
#line 20 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Edit.cshtml"
Write(Html.ValidationMessage("Nombre"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 21 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Edit.cshtml"
Write(Html.ValidationMessage("Name2"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n</div>\n\n    <div class=\"from-group\">\n        <label>Tipo</label>\n        <select class=\"form-control\" name=\"Type\">\n");
#nullable restore
#line 27 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Edit.cshtml"
             foreach (var item in ViewBag.Types)
            {

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88122c4e3a7ff5646ea7b12132707231065a7db16801", async() => {
#nullable restore
#line 29 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Edit.cshtml"
                    Write(item.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Edit.cshtml"
   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 30 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\n    </div>\n    ");
#nullable restore
#line 33 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Edit.cshtml"
Write(Html.ValidationMessage("TypeId"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    <button class=\"btn btn-primary\">Guardar</button>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
