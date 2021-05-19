namespace WebApplication1.Data.Models
{
	public class BasketItem
	{
		public int Id { get; set; }

		public virtual int BasketId { get; set; }

		public virtual Basket Basket { get; set; }

		public virtual int ProductId { get; set; }

		public virtual Product Product { get; set; }

		public int Quantity { get; set; }
	}
}
