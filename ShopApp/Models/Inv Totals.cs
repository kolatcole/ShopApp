using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Models
{
	public class Inv_Totals
	{
	    [Key]
		public int InvTId 
		{ 
			get; 
			set; 
		}
		public decimal TotalQty
		{
			get;
			set;
		}
		public decimal TotalAmt
		{
			get;
			set;
		}
	}
}
