using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication1.Data.Models;
using WebApplication1.Ecom.Services;
using WebApplication1.Shared.ViewModels;
using SharedModels = WebApplication1.Shared.Models;

namespace WebApplication1.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BasketController : Controller
	{
		private readonly IBasketService _basketService;
		private readonly UserManager<ApplicationUser> _userManager;

		public BasketController(IBasketService basketService, UserManager<ApplicationUser> userManager)
		{
			this._basketService = basketService;
			this._userManager = userManager;
		}

		public IActionResult Index()
		{
			return View();
		}

		[Route("get")]
		[HttpGet]
		public async Task<SharedModels.Basket> GetOrCreateBasket()
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			return await this._basketService.GetOrCreateBasket(userId);
		}

		[Route("add")]
		[HttpPost]
		public async Task<SharedModels.Basket> AddToBasket(AddToCart product)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			return await this._basketService.AddToBasket(product, userId);
		}

		[Route("delete")]
		[HttpPost]
		public async Task<SharedModels.Basket> RemoveFromBasket(DeleteFromCart item)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			return await this._basketService.DeleteBasketItem(item.ItemId, userId);
		}

		[Route("purchase")]
		[HttpGet]
		public async Task<SharedModels.Basket> Purchase()
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			return await this._basketService.Purchase(userId);
		}
	}
}
