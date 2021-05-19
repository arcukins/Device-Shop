using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;
using WebApplication1.Data.Repositories;
using WebApplication1.Shared.ViewModels;
using SharedModels = WebApplication1.Shared.Models;

namespace WebApplication1.Ecom.Services
{
	public class BasketService : IBasketService
	{
		private readonly IBasketRepository _basketRepository;
		private readonly IProductRepository _productRepository;
		private readonly IBasketItemRepository _basketItemRepository;
		private readonly IMapper _mapper;


		public BasketService(IBasketRepository repository, IProductRepository productRepository, IBasketItemRepository basketItemRepository, IMapper mapper)
		{
			this._basketRepository = repository;
			this._productRepository = productRepository;
			this._basketItemRepository = basketItemRepository;
			this._mapper = mapper;
		}

		private Basket getOrCreateBasket(string userId)
		{
			Basket basket = this._basketRepository.Get(b => b.UserId == userId && !b.Purchased);

			if (basket == null)
			{
				basket = new Basket { UserId = userId };
				this._basketRepository.Add(basket);
			}

			return basket;
		}

		public async Task<SharedModels.Basket> GetOrCreateBasket(string userId)
		{
			Basket basket = getOrCreateBasket(userId);
			var basketItems = this._basketItemRepository.GetBy(i => i.BasketId == basket.Id).ToList();

			return new SharedModels.Basket
			{
				Id = basket.Id,
				Products = mapBasketItems(basketItems),
				Purchased = basket.Purchased
			};
		}

		public async Task<SharedModels.Basket> AddToBasket(AddToCart products, string userId)
		{
			Product product = this._productRepository.Get(product => product.Id == products.ProductID);
			Basket basket = getOrCreateBasket(userId);


			if(product.Quantity > products.Quantity)
			{
				this._basketItemRepository.Add(new BasketItem
				{
					BasketId = basket.Id,
					ProductId = product.Id,
					Quantity = products.Quantity
				});
			} else
			{
				return null;
			}

			var basketItems = this._basketItemRepository.GetBy(i => i.BasketId == basket.Id).ToList();

			return new SharedModels.Basket
			{
				Id = basket.Id,
				Products = mapBasketItems(basketItems),
				Purchased = basket.Purchased
			};
		}


		public async Task<SharedModels.Basket> DeleteBasketItem(int id, string userId)
		{
			var basketItem = this._basketItemRepository.Get(i => i.Id == id);

			this._basketItemRepository.Delete(basketItem);

			return await GetOrCreateBasket(userId);
		}

		public async Task<SharedModels.Basket> Purchase(string userId)
		{
			Basket basket = getOrCreateBasket(userId);
			basket.Purchased = true;

			this._basketRepository.Update(basket);

			return await GetOrCreateBasket(userId);
		}

		private List<SharedModels.BasketItem> mapBasketItems(List<BasketItem> basketItems)
		{
			var list = new List<SharedModels.BasketItem>();

			foreach (BasketItem item in basketItems)
			{
				var product = this._productRepository.Get(i => i.Id == item.ProductId);
				list.Add(new SharedModels.BasketItem
				{
					Id = item.Id,
					Quantity = item.Quantity,
					Product = new SharedModels.Product
					{
						Id = product.Id,
						Name = product.Name,
						Description = product.Description,
						ImageUrl = product.ImageUrl,
						Manufacturer = product.Manufacturer,
						OriginalPrice = product.OriginalPrice,
						Price = product.Price,
						Quantity = product.Quantity,
						UniqueName = product.UniqueName
					}
				});
			}

			return list;
		}
	}

	public interface IBasketService
	{
		Task<SharedModels.Basket> GetOrCreateBasket(string userId);

		Task<SharedModels.Basket> AddToBasket(AddToCart products, string userId);

		Task<SharedModels.Basket> DeleteBasketItem(int id, string userId);

		Task<SharedModels.Basket> Purchase(string userId);
	}
}
