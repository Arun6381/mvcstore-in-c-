using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using storeMVC.Services;

namespace storeMVC.Controllers
{
	public class ProductController : Controller
	{
		private readonly ApplicationDbcontext context;
		public ProductController(ApplicationDbcontext context)
		{
			this.context = context;
		}
		public IActionResult Index()
		{
			var products = context.Products.OrderByDescending(p=>p.Id).ToList();
			return View(products);
		}

	}
}