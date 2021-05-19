using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data.Models;
using WebApplication1.Data.Repositories;

namespace WebApplication1.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProductController : ControllerBase
	{
		private readonly IProductRepository _productService;

		public ProductController(IProductRepository productService)
		{
			this._productService = productService;
		}

		public IActionResult Index()
		{
			return NotFound();
		}

		[Route("GetAll")]
		[HttpGet]
		public IEnumerable<Product> GetProducts()
		{
			return this._productService.GetAll().ToArray();
		}

		[Route("{uniqueName}")]
		[HttpGet]
		public Product GetProduct(string uniqueName)
		{
			return this._productService.GetProductByUniqueName(uniqueName);
		}
	}
}
