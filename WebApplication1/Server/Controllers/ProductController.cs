using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Server.Models;
using WebApplication1.Server.Services;

namespace WebApplication1.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
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
