#pragma checksum "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf766f3c0868a3b590f1b378b0c65bf47b9e1a0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mantenimiento.Pages.Vehiculos.Pages_Vehiculos_Details), @"mvc.1.0.razor-page", @"/Pages/Vehiculos/Details.cshtml")]
namespace Mantenimiento.Pages.Vehiculos
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
#line 1 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\_ViewImports.cshtml"
using Mantenimiento;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf766f3c0868a3b590f1b378b0c65bf47b9e1a0b", @"/Pages/Vehiculos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1e4bf29dc9257409a7052e4fb9d32d05efa041", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vehiculos_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h2 class=\"text-info\">Detalles</h2>\r\n    <br>\r\n        <div class=\"shadow-lg p-3 mb-2 bg-body rounded fondo1\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 14 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Vehiculo.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Vehiculo.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 20 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Vehiculo.Combustible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Vehiculo.Combustible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Vehiculo.Placa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Vehiculo.Placa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Vehiculo.Cilindraje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Vehiculo.Cilindraje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Vehiculo.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Vehiculo.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Vehiculo.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Vehiculo.Cliente.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Vehiculo.Servicios));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </dt>
                <dd class=""col-sm-10"">
                    <table class=""table"">
                        <tr>
                            <th>FechaCreacion</th>
                            <th>Descripcion</th>
                            <th>Tecnico</th>
                        </tr>
");
#nullable restore
#line 59 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
                     foreach (var item in Model.Vehiculo.Servicios)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 62 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 63 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 64 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Tecnico.NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf766f3c0868a3b590f1b378b0c65bf47b9e1a0b11342", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Nancy\Desktop\ProyectoMintic\Mantenimiento\Pages\Vehiculos\Details.cshtml"
                                                           WriteLiteral(Model.Vehiculo.VehiculoID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf766f3c0868a3b590f1b378b0c65bf47b9e1a0b13624", async() => {
                WriteLiteral("to return");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mantenimiento.Pages_Vehiculos.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mantenimiento.Pages_Vehiculos.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mantenimiento.Pages_Vehiculos.DetailsModel>)PageContext?.ViewData;
        public Mantenimiento.Pages_Vehiculos.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
