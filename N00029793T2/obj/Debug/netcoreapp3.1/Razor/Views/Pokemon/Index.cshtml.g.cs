#pragma checksum "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93f8e67afeef5788db08607d37b4cc13afbcb0c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemon_Index), @"mvc.1.0.view", @"/Views/Pokemon/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93f8e67afeef5788db08607d37b4cc13afbcb0c4", @"/Views/Pokemon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f0f34b3ff249ca0b1f14cac75b8c7d19f0ae67", @"/Views/_ViewImports.cshtml")]
    public class Views_Pokemon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 3 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Index.cshtml"
   List<Pokemon> por = ((List<Pokemon>)Model); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Pokemon </h1>\n<h3>Total de Pokemones capturados: ");
#nullable restore
#line 6 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Index.cshtml"
                              Write(por.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h3>
<a href=""/Pokemon/capturados"">Pokemones capturados</a>
<a href=""/Pokemon/create"">Crear Pokemon</a>

<table class=""table"">
    <thead>
        <tr>
            <th>Imagen</th>
            <th>Nombre</th>
            <th>Tipo</th>
            <th></th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 21 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Index.cshtml"
         foreach (var item in por)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        <img");
            BeginWriteAttribute("src", " src=\"", 484, "\"", 505, 1);
#nullable restore
#line 25 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 490, item.RutaImgPo, 490, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"50\" alt=\"Alternate Text\" />\n    </td>\n    <td>");
#nullable restore
#line 27 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Index.cshtml"
   Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 28 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Index.cshtml"
   Write(item.Type.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n        <a");
            BeginWriteAttribute("href", " href=\"", 641, "\"", 684, 2);
            WriteAttributeValue("", 648, "/Pokemon/Capturar?PokemonId=", 648, 28, true);
#nullable restore
#line 30 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 676, item.Id, 676, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Capturar</a>\n        <a");
            BeginWriteAttribute("href", " href=\"", 709, "\"", 748, 2);
            WriteAttributeValue("", 716, "/Pokemon/Edit?PokemonId=", 716, 24, true);
#nullable restore
#line 31 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 740, item.Id, 740, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\n        <a");
            BeginWriteAttribute("href", " href=\"", 771, "\"", 812, 2);
            WriteAttributeValue("", 778, "/Pokemon/Delete?PokemonId=", 778, 26, true);
#nullable restore
#line 32 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 804, item.Id, 804, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Eliminar</a>\n    </td>\n</tr>");
#nullable restore
#line 34 "D:\upn_2020-2\Diars\N00029793T2\N00029793T2\Views\Pokemon\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
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