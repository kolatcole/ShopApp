using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Models
{
	public class Product
	{
		public int Id
		{
			get;
			set;
		}
		public string Name 
		{
			get;
			set;
		}
		public decimal Price
		{
			get;
			set;
		}
		
		public decimal Total
		{
			get
			{
				return Convert.ToDecimal(Price * (Extra + Large + Medium + Small));
			}
			set { }
			
			
		}
		
		public string PhotoPath
		{
			get;
			set;
		}
		public int Small
		{
			get;
			set;
		}
		public int Large
		{
			get;
			set;
		}
		public int Extra
		{
			get;
			set;
		}
		public int Medium
		{
			get;
			set;
		}
		public int Quantity
		{
			get 
			{
				return Small + Medium + Large + Extra;
			}
			set { }
		}
	}
}
