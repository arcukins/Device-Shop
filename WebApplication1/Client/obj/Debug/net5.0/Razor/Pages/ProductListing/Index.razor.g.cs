#pragma checksum "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductListing\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4322b153f578b1005847f980394bfb727fb0308d"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Client.Pages.ProductListing
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
#line 2 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductListing\Index.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductListing\Index.razor"
using WebApplication1.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductListing\Index.razor"
using WebApplication1.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductListing\Index.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductListing\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-x42z1sd1x9>Index</h3>");
#nullable restore
#line 11 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductListing\Index.razor"
 if (products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p b-x42z1sd1x9><em b-x42z1sd1x9>Loading...</em></p>");
#nullable restore
#line 14 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductListing\Index.razor"
    return;
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "productListing");
            __builder.AddAttribute(4, "b-x42z1sd1x9");
#nullable restore
#line 18 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductListing\Index.razor"
     for (int i = 0; i < products.Count(); i++)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<WebApplication1.Client.Components.ProductCard>(5);
            __builder.AddAttribute(6, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WebApplication1.Shared.Models.Product>(
#nullable restore
#line 20 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductListing\Index.razor"
                                     products[i]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ProductChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<WebApplication1.Shared.Models.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<WebApplication1.Shared.Models.Product>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => products[i] = __value, products[i]))));
            __builder.CloseComponent();
#nullable restore
#line 21 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductListing\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Smartkey\Documents\Device-Shop\WebApplication1\Client\Pages\ProductListing\Index.razor"
       
    private Product[] products;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            products = await Http.GetFromJsonAsync<Product[]>("api/Product/GetAll");
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
