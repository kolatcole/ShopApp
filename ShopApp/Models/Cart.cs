
using ShopApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Models
{
	public class Cart
	{
		//public int Id { get; set; }
		public Guid CartId { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public string Size { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
		public decimal Total 
		{
			get { return Price * Quantity; }
			set { }
		}
		//public AppUser User { get; set; }
		//public int UserId { get; set; }


	}
}
