using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApplication1.Server.Services
{
	public interface IService<T> where T : class
	{
		T Add(T entity);

		T Update(T entity);

		void Delete(T entity);

		Task<T> GetById(int id);

		IQueryable<T> GetAll();

		T Get(Expression<Func<T, bool>> where);
	}
}
