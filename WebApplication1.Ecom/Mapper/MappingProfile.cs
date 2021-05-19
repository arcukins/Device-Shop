using AutoMapper;
using System.Collections.Generic;
using WebApplication1.Data.Models;
using SharedModels = WebApplication1.Shared.Models;

namespace WebApplication1.Ecom.Mapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<List<BasketItem>, List<SharedModels.BasketItem>>();
			CreateMap<BasketItem, SharedModels.BasketItem>();
		}
	}
}
