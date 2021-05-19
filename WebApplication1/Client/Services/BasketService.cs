using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApplication1.Shared.Models;
using WebApplication1.Shared.State;
using WebApplication1.Shared.ViewModels;

namespace WebApplication1.Client.Services
{
	public class BasketService : IBasketService
	{
		private readonly HttpClient _client;
		private readonly StateContainer _state;

		public BasketService(HttpClient client, StateContainer state)
		{
			this._client = client;
			this._state = state;
		}

		public async Task<Basket> GetBasket()
		{
			if (this._state?.Basket == null)
			{
				try
				{ 
					Basket basket = await this._client.GetFromJsonAsync<Basket>($"api/Basket/get");
					this._state.Basket = basket;
					this._state.NotifyStateChanged();
				} catch(Exception e)
				{
					Console.WriteLine(e);
				}
			}

			return this._state.Basket;
		}

		public async Task<Basket> AddToCart(AddToCart product)
		{
			try
			{
				var response = await this._client.PostAsJsonAsync($"api/Basket/add", product);
				var basket = await response.Content.ReadFromJsonAsync<Basket>();
				return basket;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}

			return this._state.Basket;
		}

		public async Task<Basket> DeleteBasketItem(int itemId)
		{
			try
			{
				var response = await this._client.PostAsJsonAsync($"api/Basket/delete", new DeleteFromCart { ItemId = itemId });
				var basket = await response.Content.ReadFromJsonAsync<Basket>();
				return basket;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}

			return this._state.Basket;
		}

		public async Task<Basket> Purchase()
		{
			try
			{
				var basket = await this._client.GetFromJsonAsync<Basket>($"api/Basket/purchase");
				return basket;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}

			return this._state.Basket;
		}
	}

	interface IBasketService 
	{
		Task<Basket> GetBasket();

		Task<Basket> AddToCart(AddToCart product);

		Task<Basket> DeleteBasketItem(int itemId);

		Task<Basket> Purchase();
	}
}
