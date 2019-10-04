using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Models
{
	public class ProductVM
	{
		

		[Required]
		[DataType(DataType.Text)]
		public string Name
		{
			get;
			set;
		}
		[Required]
		[DataType(DataType.Currency)]
		public decimal Price
		{
			get;
			set;
		}
		[Required]
		
		public int Quantity
		{
			get;
			set;
		}
		[Required]
		[DataType(DataType.Currency)]
		public decimal Total
		{
			get;
			set;
		}
		[Required]
		[DataType(DataType.ImageUrl)]
		public IFormFile Photo
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
		


	}
}
