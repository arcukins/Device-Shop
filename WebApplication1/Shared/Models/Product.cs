namespace WebApplication1.Shared.Models
{
	public class Product
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string UniqueName { get; set; }

		public string Manufacturer { get; set; }

		public string Description { get; set; }

		public string ImageUrl { get; set; }

		public int Quantity { get; set; }

		public double Price { get; set; }

		public double OriginalPrice { get; set; }
	}
}
