#pragma checksum "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\Payment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8045931a9c77bd23a597de058bbc6cfcce5d683"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Client.Components.Checkout
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
#line 3 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
#line 1 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\Payment.razor"
using WebApplication1.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\Payment.razor"
using WebApplication1.Shared.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\Payment.razor"
using WebApplication1.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class Payment : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddMarkupContent(1, "<div class=\"form-group\"><label for=\"name\">Name</label>\r\n        <input type=\"email\" class=\"form-control\" id=\"name\" placeholder=\"Enter your name\"></div>\r\n    ");
            __builder.AddMarkupContent(2, "<div class=\"form-group\"><label for=\"lastName\">Last name</label>\r\n        <input type=\"email\" class=\"form-control\" id=\"lastName\" placeholder=\"Enter your last name\"></div>\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"form-group\"><label for=\"city\">City</label>\r\n        <input type=\"email\" class=\"form-control\" id=\"city\" placeholder=\"Enter city\"></div>\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"form-group\"><label for=\"street\">Street</label>\r\n        <input type=\"email\" class=\"form-control\" id=\"street\" placeholder=\"Enter street\"></div>\r\n    ");
            __builder.AddMarkupContent(5, "<div class=\"form-group\"><label for=\"postalCode\">Postal code</label>\r\n        <input type=\"email\" class=\"form-control\" id=\"postalCode\" placeholder=\"Enter postal code\"></div>\r\n\r\n    ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "type", "submit");
            __builder.AddAttribute(8, "class", "btn btn-danger");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\Payment.razor"
                                                           purchase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "BUY ME!!");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\Payment.razor"
       
    protected override void OnInitialized()
    {
        state.OnChange += StateHasChanged;
    }

    private async Task purchase()
    {
        var basket = await basketService.Purchase();
        state.Basket = basket;
        NavManager.NavigateTo("/checkout/confirm");
    }

    public void Dispose()
    {
        state.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBasketService basketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateContainer state { get; set; }
    }
}
#pragma warning restore 1591