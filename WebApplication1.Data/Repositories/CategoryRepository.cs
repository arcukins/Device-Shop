using WebApplication1.Data.Data;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Repositories
{
	public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
	{
		public CategoryRepository(IApplicationDbContext dataContext) 
			: base(dataContext)
		{
		}
	}

	public interface ICategoryRepository : IRepository<Category>
	{
	}
}
