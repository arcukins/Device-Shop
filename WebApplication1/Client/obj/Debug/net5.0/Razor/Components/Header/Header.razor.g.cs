#pragma checksum "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Header\Header.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ffe3c69804d1bd5af00e8d6d8c83e8db810dfef"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Client.Components.Header
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\_Imports.razor"
using WebApplication1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\_Imports.razor"
using WebApplication1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Header\Header.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Header\Header.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Header\Header.razor"
using WebApplication1.Shared.State;

#line default
#line hidden
#nullable disable
    public partial class Header : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "header");
                __builder2.AddAttribute(4, "b-lu9go2phqk");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "container");
                __builder2.AddAttribute(7, "b-lu9go2phqk");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddAttribute(10, "b-lu9go2phqk");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddAttribute(13, "b-lu9go2phqk");
                __builder2.AddMarkupContent(14, "<div class=\"header-left\" b-lu9go2phqk><div class=\"logo\" b-lu9go2phqk><a href b-lu9go2phqk><img src=\"images/logo.png\" alt b-lu9go2phqk></a></div>\r\n                            <div class=\"clear\" b-lu9go2phqk></div></div>\r\n                        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "header_right");
                __builder2.AddAttribute(17, "b-lu9go2phqk");
                __builder2.OpenElement(18, "ul");
                __builder2.AddAttribute(19, "class", "icon1 sub-icon1 profile_img");
                __builder2.AddAttribute(20, "b-lu9go2phqk");
                __builder2.OpenElement(21, "li");
                __builder2.AddAttribute(22, "b-lu9go2phqk");
                __builder2.AddMarkupContent(23, "<a class=\"active-icon c1\" href=\"#\" b-lu9go2phqk></a>\r\n                                    ");
                __builder2.OpenElement(24, "ul");
                __builder2.AddAttribute(25, "class", "sub-icon1 list");
                __builder2.AddAttribute(26, "b-lu9go2phqk");
                __builder2.OpenElement(27, "a");
                __builder2.AddAttribute(28, "class", "userName");
                __builder2.AddAttribute(29, "href", "authentication/profile");
                __builder2.AddAttribute(30, "b-lu9go2phqk");
                __builder2.AddContent(31, "Hello, ");
                __builder2.AddContent(32, 
#nullable restore
#line 27 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Header\Header.razor"
                                                                                                  context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(33, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                                        <div class=\"clear\" b-lu9go2phqk></div>\r\n                                        ");
                __builder2.OpenComponent<WebApplication1.Client.Components.Header.ProductCart>(35);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n                                        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "login_buttons");
                __builder2.AddAttribute(39, "b-lu9go2phqk");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "check_button" + " " + (
#nullable restore
#line 31 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Header\Header.razor"
                                                                       !hasProductsInBasket ? "disabled" : ""

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "b-lu9go2phqk");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
                __builder2.AddAttribute(44, "class", "readMore");
                __builder2.AddAttribute(45, "href", "checkout");
                __builder2.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(47, "<span b-lu9go2phqk>Check out</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                                            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "login_button");
                __builder2.AddAttribute(51, "b-lu9go2phqk");
                __builder2.OpenElement(52, "a");
                __builder2.AddAttribute(53, "class", "login_button");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Header\Header.razor"
                                                                                  BeginSignOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "b-lu9go2phqk");
                __builder2.AddContent(56, "Log out");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                                            <div class=\"clear\" b-lu9go2phqk></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                                        <div class=\"clear\" b-lu9go2phqk></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                            <div class=\"clear\" b-lu9go2phqk></div>");
                __builder2.CloseElement();
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
#line 53 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Header\Header.razor"
       
    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }

    private bool hasProductsInBasket;

    protected override void OnInitialized()
    {
        state.OnChange += StateHasChanged;

        hasProductsInBasket = state.Basket?.Products?.Count > 0;

        Console.WriteLine(hasProductsInBasket);
    }

    public void Dispose()
    {
        state.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateContainer state { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
