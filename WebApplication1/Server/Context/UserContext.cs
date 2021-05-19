using Microsoft.AspNetCore.Http;
using Microsoft.JSInterop;
using System.Text.Json;
using WebApplication1.Shared.Models;

namespace WebApplication1.Server.Context
{
	public class UserContext
	{
		private readonly HttpContext _httpContext;

		public UserContext(IHttpContextAccessor httpContext)
		{
			this._httpContext = httpContext.HttpContext;
		}

		public EcomCookie GetEcomCookie()
		{
			string ecomCookieJson = "";
			this._httpContext.Request.Cookies.TryGetValue(CookieKeys.EcomCookieKey, out ecomCookieJson);

			if(string.IsNullOrEmpty(ecomCookieJson))
			{
				return null;
			}

			return JsonSerializer.Deserialize<EcomCookie>(ecomCookieJson);
		}

		public void SetEcomCookie(Basket basket)
		{
			EcomCookie cookieValue = new EcomCookie { BasketId = basket.Id };
			string value = JsonSerializer.Serialize(cookieValue);

			this._httpContext.Response.Cookies.Append(CookieKeys.EcomCookieKey, value);
		}
	}
}
