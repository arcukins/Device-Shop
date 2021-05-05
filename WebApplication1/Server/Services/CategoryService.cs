using WebApplication1.Server.Data;
using WebApplication1.Server.Models;

namespace WebApplication1.Server.Services
{
	public class CategoryService : BaseService<Category>, ICategoryService
	{
		public CategoryService(IApplicationDbContext dataContext) 
			: base(dataContext)
		{
		}
	}

	public interface ICategoryService : IService<Category>
	{
	}
}
