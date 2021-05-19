using WebApplication1.Data.Data;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Repositories
{
	public class BasketRepository : BaseRepository<Basket>, IBasketRepository
	{
		public BasketRepository(IApplicationDbContext dataContext)
			:base(dataContext)
		{

		}
	}

	public interface IBasketRepository : IRepository<Basket>
	{

	}
}
