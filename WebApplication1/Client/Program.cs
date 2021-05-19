using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Client.Services;
using WebApplication1.Shared.State;

namespace WebApplication1.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			//State singleton
			builder.Services.AddSingleton<StateContainer>();

			builder.RootComponents.Add<App>("#app");

			builder.Services.AddHttpClient("WebApplication1.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
				.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

			// Supply HttpClient instances that include access tokens when making requests to the server project
			builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("WebApplication1.ServerAPI"));

			builder.Services.AddApiAuthorization();

			//Services
			builder.Services.AddScoped<IBasketService, BasketService>();

			await builder.Build().RunAsync();
		}
	}
}
