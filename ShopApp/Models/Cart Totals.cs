using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Models
{
	public class Cart_Totals
	{
		public int id 
		{
			get;
			set;
		}
		public decimal subTotal
		{
			get;
			set;
		}
		public decimal discount
		{
			get { return 10; }
			set { }
		}
		public decimal Total
		{
			get { return subTotal + discount; }
			set { }
		}
	}
}
