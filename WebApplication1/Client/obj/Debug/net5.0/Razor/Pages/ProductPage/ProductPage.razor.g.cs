#pragma checksum "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf0321ff88529b33d47979b94280f38d354139ea"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Client.Pages.ProductPage
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
#line 2 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
using WebApplication1.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
using WebApplication1.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
using WebApplication1.Shared.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
using WebApplication1.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{UniqueName}")]
    public partial class ProductPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 13 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
 if (this.product == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p b-xae5ruvu35><em b-xae5ruvu35>Loading...</em></p>");
#nullable restore
#line 16 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
    return;
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "productDescriptionBlock");
            __builder.AddAttribute(3, "b-xae5ruvu35");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "productDetails");
            __builder.AddAttribute(6, "b-xae5ruvu35");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "productImage");
            __builder.AddAttribute(9, "b-xae5ruvu35");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 22 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
                       this.product.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "b-xae5ruvu35");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "nameDescriptionBlock");
            __builder.AddAttribute(16, "b-xae5ruvu35");
            __builder.OpenElement(17, "h3");
            __builder.AddAttribute(18, "b-xae5ruvu35");
            __builder.AddContent(19, 
#nullable restore
#line 26 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
                 this.product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "b-xae5ruvu35");
            __builder.AddContent(23, 
#nullable restore
#line 27 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
                this.product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "productActions");
            __builder.AddAttribute(27, "b-xae5ruvu35");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "b-xae5ruvu35");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "class", "price");
            __builder.AddAttribute(32, "b-xae5ruvu35");
            __builder.AddContent(33, "$");
            __builder.AddContent(34, 
#nullable restore
#line 32 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
                                      this.product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
                 if (this.hasDiscount)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "span");
            __builder.AddAttribute(36, "class", "discountPrice");
            __builder.AddAttribute(37, "b-xae5ruvu35");
            __builder.AddContent(38, "$");
            __builder.AddContent(39, 
#nullable restore
#line 35 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
                                                  this.product.OriginalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.AddMarkupContent(41, "<span class=\"qty\" b-xae5ruvu35>QUANTITY:</span>\r\n            ");
            __builder.OpenElement(42, "select");
            __builder.AddAttribute(43, "class", "qtySelect");
            __builder.AddAttribute(44, "b-xae5ruvu35");
#nullable restore
#line 41 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
                 for (int i = 0; i < this.quantityOptions.Count(); i++)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "option");
            __builder.AddAttribute(46, "b-xae5ruvu35");
            __builder.AddContent(47, 
#nullable restore
#line 43 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
                             this.quantityOptions[i]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.AddMarkupContent(49, "<button type=\"submit\" class=\"addToCart\" b-xae5ruvu35><span b-xae5ruvu35>Add to cart</span></button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "desc");
            __builder.AddAttribute(53, "b-xae5ruvu35");
            __builder.AddMarkupContent(54, "<h4 b-xae5ruvu35>DESCRIPTION</h4>\r\n    ");
            __builder.OpenElement(55, "p");
            __builder.AddAttribute(56, "b-xae5ruvu35");
            __builder.AddContent(57, 
#nullable restore
#line 54 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
        this.product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductPage\ProductPage.razor"
       
    [Parameter]
    public string UniqueName { get; set; }

    private Product product { get; set; }

    private List<int> quantityOptions = new List<int>();

    private bool hasDiscount;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            product = await Http.GetFromJsonAsync<Product>($"api/Product/{UniqueName}");

            quantityOptions.AddRange(
                product.Quantity > 10
                ? Enumerable.Range(1, 10)
                : Enumerable.Range(1, product.Quantity));

            this.hasDiscount = this.product?.OriginalPrice - this.product?.Price > 0;
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

    private async void AddToCart()
    {

        var product = new AddToCart
        {
            ProductID = this.product.Id,
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
