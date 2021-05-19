#pragma checksum "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bad6ccbd815b5e4d863ea273583e8c9571bf49d4"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Client.Components
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
#line 1 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
using WebApplication1.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
using WebApplication1.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
using WebApplication1.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
using WebApplication1.Shared.State;

#line default
#line hidden
#nullable disable
    public partial class ProductCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "productCard");
            __builder.AddAttribute(2, "b-f63e0dzb6j");
#nullable restore
#line 9 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
     if (this.HasDiscount)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<div class=\"saleBadge\" b-f63e0dzb6j><span class=\"saleLabel\" b-f63e0dzb6j>SALE</span></div>");
#nullable restore
#line 14 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "productImage");
            __builder.AddAttribute(6, "b-f63e0dzb6j");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 16 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
                   this.Product.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "b-f63e0dzb6j");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "b-f63e0dzb6j");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "href", "counter");
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "productName");
                __builder2.AddAttribute(18, "b-f63e0dzb6j");
                __builder2.AddContent(19, 
#nullable restore
#line 20 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
                                      this.Product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "productManufacturer");
            __builder.AddAttribute(23, "b-f63e0dzb6j");
            __builder.AddContent(24, 
#nullable restore
#line 22 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
                                          this.Product.Manufacturer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "d-flex");
            __builder.AddAttribute(28, "b-f63e0dzb6j");
#nullable restore
#line 25 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
         if (HasDiscount)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "productReducedFromPrice");
            __builder.AddAttribute(31, "b-f63e0dzb6j");
            __builder.AddContent(32, "$ ");
            __builder.AddContent(33, 
#nullable restore
#line 27 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
                                                    this.Product.OriginalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "productPrice");
            __builder.AddAttribute(36, "b-f63e0dzb6j");
            __builder.AddContent(37, "$ ");
            __builder.AddContent(38, 
#nullable restore
#line 30 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
                                     this.Product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "productActions");
            __builder.AddAttribute(42, "b-f63e0dzb6j");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
                          AddToCart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "class", "addToCard");
            __builder.AddAttribute(46, "href", "counter");
            __builder.AddAttribute(47, "b-f63e0dzb6j");
            __builder.OpenElement(48, "span");
            __builder.AddAttribute(49, "b-f63e0dzb6j");
            __builder.AddContent(50, 
#nullable restore
#line 35 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
                    !this.productIsInCart ? "Add to cart" : "To Checkout"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(52);
            __builder.AddAttribute(53, "class", "readMore");
            __builder.AddAttribute(54, "href", 
#nullable restore
#line 37 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
                                         this.ProductUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(56, "<span b-f63e0dzb6j>Read More</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Components\ProductCard.razor"
       
    [Parameter]
    public Product Product { get; set; }

    [Parameter]
    public EventCallback<Product> ProductChanged { get; set; }

    private bool HasDiscount;

    private string ProductUrl;

    private bool productIsInCart;

    protected override void OnInitialized()
    {
        state.OnChange += StateHasChanged;

        Task.Delay(3000);

        this.HasDiscount = Product?.OriginalPrice - Product?.Price > 0;

        this.ProductUrl = $"product/{Product.UniqueName}";

        this.productIsInCart = state?.Basket?.Products.Any(p => p.Id == this.Product.Id) ?? false;
    }

    private async void AddToCart()
    {
        if (productIsInCart)
        {
            return;
        }

        var product = new AddToCart
        {
            ProductID = this.Product.Id,
            Quantity = 1
        };

        state.Basket = await basketService.AddToCart(product);

        Console.WriteLine("added");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateContainer state { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBasketService basketService { get; set; }
    }
}
#pragma warning restore 1591