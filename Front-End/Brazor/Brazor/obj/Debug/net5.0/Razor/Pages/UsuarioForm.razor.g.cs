#pragma checksum "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09ba9f8678a52e5f46b78d76b1688b76879f87ef"
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
            __builder.AddMarkupContent(0, "<h3>Usuario</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
                 oUsuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "container-fluid");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(10, "<label class=\"col-sm-3\">Usuario</label>\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
                                                             oUsuario.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oUsuario.UserName = __value, oUsuario.UserName))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oUsuario.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                ");
                __Blazor.Brazor.Pages.UsuarioForm.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 19 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
                                        (()=>oUsuario.UserName)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(24, "<label class=\"col-sm-3\">Nombre</label>\r\n            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
                                                             oUsuario.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oUsuario.Nombre = __value, oUsuario.Nombre))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oUsuario.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n                ");
                __Blazor.Brazor.Pages.UsuarioForm.TypeInference.CreateValidationMessage_1(__builder2, 33, 34, 
#nullable restore
#line 26 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
                                        (()=>oUsuario.Nombre)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(38, "<label class=\"col-sm-3\">Email</label>\r\n            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
                                                             oUsuario.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oUsuario.Email = __value, oUsuario.Email))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oUsuario.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n                ");
                __Blazor.Brazor.Pages.UsuarioForm.TypeInference.CreateValidationMessage_2(__builder2, 47, 48, 
#nullable restore
#line 33 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
                                        (()=>oUsuario.Email)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(52, "<label class=\"col-sm-3\">Telefono</label>\r\n            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "class", "form-control");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
                                                             oUsuario.Telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oUsuario.Telefono = __value, oUsuario.Telefono))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oUsuario.Telefono));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group row mb-1");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "col-sm-12");
                __builder2.OpenElement(65, "button");
                __builder2.AddAttribute(66, "class", "btn btn-primary");
                __builder2.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
                                                          Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(68, "Guardar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                ");
                __builder2.OpenElement(70, "button");
                __builder2.AddAttribute(71, "class", "btn btn-secondary");
                __builder2.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Lautaro\Desktop\Brazor prueba\Brazor\Brazor\Pages\UsuarioForm.razor"
                                                           Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(73, "Cancelar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.Brazor.Pages.UsuarioForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
