using WebApplication1.Server.Data;
using WebApplication1.Server.Models;

namespace WebApplication1.Server.Services
{
	public class ProductService : BaseService<Product>, IProductService
	{
		public ProductService(IApplicationDbContext dataContext) 
			: base(dataContext)
		{
		}
	}

	public interface IProductService : IService<Product>
	{
	}
}
