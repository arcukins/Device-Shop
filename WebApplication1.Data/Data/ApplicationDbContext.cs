using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Data
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

		public DbSet<Basket> Baskets { get; set; }

		public DbSet<BasketItem> BasketItems { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			var assembly = Assembly.GetExecutingAssembly();
			builder.ApplyConfigurationsFromAssembly(assembly);

			builder.Entity<Product>()
				.HasOne(i => i.Category)
				.WithMany(o => o.Products)
				.HasForeignKey(k => k.CategoryId);

			builder.Entity<BasketItem>()
				.HasOne(i => i.Basket)
				.WithMany(o => o.Products)
				.HasForeignKey(k => k.BasketId);

			builder.Entity<Basket>()
				.HasMany(i => i.Products)
				.WithOne(i => i.Basket);
		}
	}

	public interface IApplicationDbContext
	{
		DbSet<TEntity> Set<TEntity>() where TEntity : class;

		DbSet<Category> Categories { get; set; }

		DbSet<Product> Products { get; set; }

		DbSet<Basket> Baskets { get; set; }

		DbSet<BasketItem> BasketItems { get; set; }

		int SaveChanges();
	}
}
