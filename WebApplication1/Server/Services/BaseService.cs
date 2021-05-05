using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApplication1.Server.Data;

namespace WebApplication1.Server.Services
{
	public abstract class BaseService<T> where T : class
	{
		private IApplicationDbContext _dbContext;
		private readonly DbSet<T> _dbSet;

		protected BaseService(IApplicationDbContext dbContext)
		{
			this._dbContext = dbContext;
			this._dbSet = this._dbContext.Set<T>();
		}

		public virtual T Add(T entity)
		{
			this._dbSet.Add(entity);
			this._dbContext.SaveChanges();

			return entity;
		}

		public virtual T Update(T entity)
		{
			this._dbSet.Update(entity);
			this._dbContext.SaveChanges();

			return entity;
		}

		public virtual void Delete(T entity)
		{
			this._dbSet.Remove(entity);
			this._dbContext.SaveChanges();
		}

		public async virtual Task<T> GetById(int id)
		{
			return await this._dbSet.FindAsync(id);
		}

		public virtual IQueryable<T> GetAll()
		{
			return this._dbSet;
		}

		public virtual T Get(Expression<Func<T, bool>> where)
		{
			return this._dbSet.FirstOrDefault(where);
		}
	}
}
