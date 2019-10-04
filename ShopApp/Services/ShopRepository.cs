using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using ShopApp.Data;
using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Services
{
	public class ShopRepository:IShopRepository
	{
		public readonly IHostingEnvironment hostingEnvironment;
		public readonly ApplicationDbContext context;
	
		public ShopRepository(ApplicationDbContext _context,IHostingEnvironment _hostingEnvironment) 
		{
			context = _context;
			hostingEnvironment = _hostingEnvironment;
			
		}

		public IEnumerable<Product> ShowAllProducts() {

			var item = context.Products/*.Where(x => x.Extra+x.Large+x.Medium+x.Small==0)*/;
			return item;
		
		}
		public IEnumerable<Cart> ShowAllCarts()
		{

			var item = context.Carts/*.Where(x => x.Extra+x.Large+x.Medium+x.Small==0)*/;
			return item;

		}

		public bool Create(Product product, ProductVM model) 
		{
			
			
			string uniqueFileName = null;
			if (model.Photo != null)
			{
				string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
				uniqueFileName =Path.GetFileName(model.Photo.FileName);
				string filePath = Path.Combine(uploadsFolder, uniqueFileName);
				model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
			}
			Product prod = new Product
			{
				Name = product.Name,
				PhotoPath=uniqueFileName,
				Price=product.Price,
				Small=product.Small,
				Extra=product.Extra,
				Large=product.Large,
				Medium=product.Medium,
				Total=product.Total
			};
			context.Products.Add(prod);
			var result=context.SaveChanges();
			return result == 1;
		}
		public bool AddToCart(int id,string size,int quantity) 
		{
			var product = context.Products.Find(id);
			if (product == null)
			{
				return false;

			}
			if (size == "Small")
			{
				product.Small = product.Small - quantity;
			}
			else if (size == "Medium")
			{
				product.Medium = product.Medium - quantity;
			}
			else if (size == "Large")
			{
				product.Large = product.Large - quantity;
			}
			else
			{
				product.Extra = product.Extra - quantity;
			}

				Cart cartItem = new Cart
			{
				CartId = new Guid(),
				Name = product.Name,
				Image = product.PhotoPath,
				Quantity = quantity, 
				Price = product.Price,
				Size  = size,
				
				Total = product.Total
			};
			context.Carts.Add(cartItem);
			var result=context.SaveChanges();
			return result == 1;



		}
		public Product GetSingle(int id)
		{
			
			var product = context.Products.Where(x => x.Id == id).SingleOrDefault();
			return product;
		}
	}
}
