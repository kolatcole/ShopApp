using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Data;
using ShopApp.Models;
using ShopApp.Services;
using static System.Net.Mime.MediaTypeNames;

namespace ShopApp.Controllers
{

	[Authorize]
	public class HomeController : Controller
	{
		
		
		public readonly IShopRepository repository;
		
		public HomeController(IShopRepository _repository)
		{
			
			
			repository = _repository;
		}
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		[AllowAnonymous]
		public IActionResult Contact()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		public IActionResult Shop()
		{

			var products = repository.ShowAllProducts();

			
			return PartialView(products);
		}
		public IActionResult Inventory()
		{

			var products = repository.ShowAllProducts();


			return View(products);
		}
		public IActionResult Cart()
		{
			var carts = repository.ShowAllCarts();


			return View(carts);
		}
		
		public IActionResult Single(int id)
		{
			//var prod = context.Products.Where(x => x.Id == id).SingleOrDefault();
			var prod = repository.GetSingle(id);
			return View(prod);
		}
		public IActionResult Checkout()
		{
			return View();
		}
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(ProductVM model,Product product)
		{
			if (ModelState.IsValid)
			{
				{
					repository.Create(product, model);
				}
				return View();
			}
			return RedirectToAction();
		}
		[HttpPost]
		public IActionResult Add(int id, string size, int quantity)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}
			repository.AddToCart(id, size,quantity);
			return RedirectToAction("Cart");
		}
		
	}
}