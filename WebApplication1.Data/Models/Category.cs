using System.Collections.Generic;

namespace WebApplication1.Data.Models
{
	public class Category
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public List<Product> Products { get; set; }
	}
}
