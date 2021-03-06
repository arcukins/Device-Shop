#pragma checksum "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4793e14a7ec9a7a28e38a82870dbd00f39bb9eb"
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
#line 1 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor"
using WebApplication1.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor"
using WebApplication1.Shared.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor"
using WebApplication1.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor"
 if (basketItems != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "b-vw1dz71tou");
#nullable restore
#line 11 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor"
     for (int i = 0; i < basketItems.Count; i++)
    {
        int item = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "checkout-item");
            __builder.AddAttribute(4, "b-vw1dz71tou");
            __builder.OpenElement(5, "img");
            __builder.AddAttribute(6, "src", 
#nullable restore
#line 15 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor"
                       basketItems[i].Product.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "b-vw1dz71tou");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "b-vw1dz71tou");
            __builder.AddContent(11, 
#nullable restore
#line 16 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor"
                   basketItems[i].Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "span");
            __builder.AddAttribute(14, "b-vw1dz71tou");
            __builder.AddContent(15, 
#nullable restore
#line 17 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor"
                   basketItems[i].Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "span");
            __builder.AddAttribute(18, "b-vw1dz71tou");
            __builder.AddContent(19, 
#nullable restore
#line 18 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor"
                   basketItems[i].Product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-danger");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor"
                                                     () => deleteFromCart(basketItems[item].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "b-vw1dz71tou");
            __builder.AddContent(25, "X");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\Checkout\ProductList.razor"
       
    private IList<BasketItem> basketItems;

    protected override void OnInitialized()
    {
        state.OnChange += StateHasChanged;
        this.basketItems = state?.Basket?.Products;
    }

    private async Task deleteFromCart(int id)
    {
        var basket = await basketService.DeleteBasketItem(id);
        state.Basket = basket;
        basketItems = basket.Products;
    }

    public void Dispose()
    {
        state.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBasketService basketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateContainer state { get; set; }
    }
}
#pragma warning restore 1591
