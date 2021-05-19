using System.Collections.Generic;

namespace WebApplication1.Shared.Models
{
	public class Basket
	{
		public int Id { get; set; }

		public bool Purchased { get; set; }

		public IList<BasketItem> Products { get; set; }
	}
}
