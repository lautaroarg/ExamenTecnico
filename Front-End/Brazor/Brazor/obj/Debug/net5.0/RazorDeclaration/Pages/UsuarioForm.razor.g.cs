// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UsuarioForm")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/UsuarioForm/{Id:int}")]
    public partial class UsuarioForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
       
    [Parameter]
    public int Id { get; set; }

    Usuario oUsuario = new Usuario();
    Respuesta<object> oRespuesta = new Respuesta<object>();
    Respuesta<Usuario> oRespuestaUsuario = new Respuesta<Usuario>();
    public string Url = "/usuarios";
    private void Cancelar() => Nav.NavigateTo("/usuarios");
    private async Task Save()
    {
        if (Id!=0)
        {
            var response = await Http.PutAsJsonAsync<Usuario>(Url, oUsuario);
            oRespuesta = response.Content.ReadFromJsonAsync<Respuesta<object>>().Result;
        }
        else
        {
            var response = await Http.PostAsJsonAsync<Usuario>(Url, oUsuario);
            oRespuesta = response.Content.ReadFromJsonAsync<Respuesta<object>>().Result;
        }

        Nav.NavigateTo("/usuarios");
    }
    protected override async Task OnInitializedAsync()
    {
        if (Id !=0)
        {
            oRespuestaUsuario = await Http.GetFromJsonAsync<Data.Respuesta<Usuario>>(Url+"/"+Id);
            oUsuario = oRespuestaUsuario.Data;
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
