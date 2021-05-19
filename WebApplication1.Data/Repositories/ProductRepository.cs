using WebApplication1.Data.Data;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Repositories
{
	public class ProductRepository : BaseRepository<Product>, IProductRepository
	{
		public ProductRepository(IApplicationDbContext dataContext) 
			: base(dataContext)
		{
		}

		public Product GetProductByUniqueName(string uniqueName)
		{
			return this.Get(product => product.UniqueName == uniqueName);
		}
	}

	public interface IProductRepository : IRepository<Product>
	{
		Product GetProductByUniqueName(string uniqueName);
	}
}
