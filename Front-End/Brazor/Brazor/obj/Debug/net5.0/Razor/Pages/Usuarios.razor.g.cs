#pragma checksum "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0a41badede68711e507e71b544197448169c31e"
// <auto-generated/>
#pragma warning disable 1591
namespace Brazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\_Imports.razor"
using Brazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\_Imports.razor"
using Brazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
using Brazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/usuarios")]
    public partial class Usuarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lista de usuarios</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"row\"><div class=\"col-12 text-center\"><a href=\"UsuarioForm\" class=\"btn btn-success\">Nuevo</a></div></div>\r\n\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<tr><th>Id</th>\r\n        <th>Usuario</th>\r\n        <th>Nombre</th>\r\n        <th>Email</th>\r\n        <th>Telefono</th></tr>");
#nullable restore
#line 23 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
   if(oRespuesta.Data  != null)
            {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
       foreach (var oElement in oRespuesta.Data) { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 27 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
                 oElement.IdUsuario

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 28 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
                 oElement.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 29 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
                 oElement.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 30 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
                 oElement.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 31 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
                 oElement.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", "/UsuarioForm/" + (
#nullable restore
#line 33 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
                                       oElement.IdUsuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "btn btn-primary");
            __builder.AddContent(25, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", "/eliminarusuario/" + (
#nullable restore
#line 34 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
                                           oElement.IdUsuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "btn btn-danger");
            __builder.AddContent(30, "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
                

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\Usuarios.razor"
       
    public string Url = "/usuarios";
    public Data.Respuesta<List<Usuario>> oRespuesta = new Data.Respuesta<List<Usuario>>();
    protected override async Task OnInitializedAsync() =>
        oRespuesta = await Http.GetFromJsonAsync<Data.Respuesta<List<Usuario>>>(Url);


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
