using System.Collections.Generic;

namespace WebApplication1.Data.Models
{
	public class Basket
	{
		public int Id { get; set; }

		public string UserId { get; set; }

		public bool Purchased { get; set; }

		public virtual List<BasketItem> Products { get; set; }
	}
}
