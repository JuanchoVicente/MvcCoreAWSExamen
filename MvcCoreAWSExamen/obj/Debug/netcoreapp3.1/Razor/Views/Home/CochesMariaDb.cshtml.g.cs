#pragma checksum "C:\Users\AlumnoMCSD\source\repos\MvcCoreAWSExamen\MvcCoreAWSExamen\Views\Home\CochesMariaDb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8786167da35dd632055b1120907bac4b1aaa6482"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CochesMariaDb), @"mvc.1.0.view", @"/Views/Home/CochesMariaDb.cshtml")]
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
#line 1 "C:\Users\AlumnoMCSD\source\repos\MvcCoreAWSExamen\MvcCoreAWSExamen\Views\_ViewImports.cshtml"
using MvcCoreAWSExamen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AlumnoMCSD\source\repos\MvcCoreAWSExamen\MvcCoreAWSExamen\Views\_ViewImports.cshtml"
using MvcCoreAWSExamen.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8786167da35dd632055b1120907bac4b1aaa6482", @"/Views/Home/CochesMariaDb.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3f767967f06345eb50109658e0c90697f6e36a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CochesMariaDb : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Coche>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\AlumnoMCSD\source\repos\MvcCoreAWSExamen\MvcCoreAWSExamen\Views\Home\CochesMariaDb.cshtml"
 if (Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AlumnoMCSD\source\repos\MvcCoreAWSExamen\MvcCoreAWSExamen\Views\Home\CochesMariaDb.cshtml"
     foreach (Coche c in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Identificador: ");
#nullable restore
#line 7 "C:\Users\AlumnoMCSD\source\repos\MvcCoreAWSExamen\MvcCoreAWSExamen\Views\Home\CochesMariaDb.cshtml"
                      Write(c.IdCoche);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h2>Marca: ");
#nullable restore
#line 8 "C:\Users\AlumnoMCSD\source\repos\MvcCoreAWSExamen\MvcCoreAWSExamen\Views\Home\CochesMariaDb.cshtml"
              Write(c.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2>Modelo: ");
#nullable restore
#line 9 "C:\Users\AlumnoMCSD\source\repos\MvcCoreAWSExamen\MvcCoreAWSExamen\Views\Home\CochesMariaDb.cshtml"
               Write(c.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2>Conductor: ");
#nullable restore
#line 10 "C:\Users\AlumnoMCSD\source\repos\MvcCoreAWSExamen\MvcCoreAWSExamen\Views\Home\CochesMariaDb.cshtml"
                  Write(c.Conductor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2>Imagen:<img");
            BeginWriteAttribute("src", " src=\"", 265, "\"", 280, 1);
#nullable restore
#line 11 "C:\Users\AlumnoMCSD\source\repos\MvcCoreAWSExamen\MvcCoreAWSExamen\Views\Home\CochesMariaDb.cshtml"
WriteAttributeValue("", 271, c.Imagen, 271, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\"/></h2>\r\n");
#nullable restore
#line 12 "C:\Users\AlumnoMCSD\source\repos\MvcCoreAWSExamen\MvcCoreAWSExamen\Views\Home\CochesMariaDb.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AlumnoMCSD\source\repos\MvcCoreAWSExamen\MvcCoreAWSExamen\Views\Home\CochesMariaDb.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>No hay coches disponibles.</h1>\r\n    <h2>Compruebe la conexi??n con MariaDb y que tiene datos.</h2>\r\n");
#nullable restore
#line 18 "C:\Users\AlumnoMCSD\source\repos\MvcCoreAWSExamen\MvcCoreAWSExamen\Views\Home\CochesMariaDb.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Coche>> Html { get; private set; }
    }
}
#pragma warning restore 1591
