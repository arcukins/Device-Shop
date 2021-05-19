using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApplication1.Data.Repositories
{
	public interface IRepository<T> where T : class
	{
		T Add(T entity);

		T Update(T entity);

		void Delete(T entity);

		Task<T> GetById(int id);

		IQueryable<T> GetAll();

		T Get(Expression<Func<T, bool>> where);

		IQueryable<T> GetBy(Expression<Func<T, bool>> where);
	}
}
