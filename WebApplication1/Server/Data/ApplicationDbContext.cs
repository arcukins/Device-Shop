using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApplication1.Server.Models;

namespace WebApplication1.Server.Data
{
	public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>, IApplicationDbContext
	{
		public ApplicationDbContext(
			DbContextOptions options,
			IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
		{
		}

		public DbSet<Category> Categories { get; set; }

		public DbSet<Product> Products { get; set; }
	}

	public interface IApplicationDbContext
	{
		DbSet<TEntity> Set<TEntity>() where TEntity : class;

		DbSet<Category> Categories { get; set; }

		DbSet<Product> Products { get; set; }

		int SaveChanges();
	}
}
