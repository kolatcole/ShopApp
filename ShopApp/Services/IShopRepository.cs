using Microsoft.AspNetCore.Identity;
using ShopApp.Data;
using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Services
{
	public interface IShopRepository
	{
		IEnumerable<Product> ShowAllProducts();
		IEnumerable<Cart> ShowAllCarts();
		bool Create(Product product,ProductVM productvm);
		bool AddToCart(int id,string size,int quantity);
		Product GetSingle(int id);
	}
}
