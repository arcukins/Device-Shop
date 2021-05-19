using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Ecom.Mapper;
using WebApplication1.Ecom.Services;

namespace WebApplication1.Ecom.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddEcom(this IServiceCollection services)
		{
			using ServiceProvider provider = services.BuildServiceProvider();

			//Services
			services.AddScoped<IBasketService, BasketService>();

			var mapperConfig = new MapperConfiguration(mc =>
			{
				mc.AddProfile(new MappingProfile());
			});
			IMapper mapper = mapperConfig.CreateMapper();
			services.AddSingleton(mapper);

			return services;
		}
	}
}
