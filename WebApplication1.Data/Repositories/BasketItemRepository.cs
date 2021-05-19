using WebApplication1.Data.Data;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Repositories
{
	public class BasketItemRepository : BaseRepository<BasketItem>, IBasketItemRepository
	{
		public BasketItemRepository(IApplicationDbContext dataContext)
			:base(dataContext)
		{

		}
	}

	public interface IBasketItemRepository : IRepository<BasketItem>
	{

	}
}
