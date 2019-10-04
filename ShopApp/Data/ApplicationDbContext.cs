using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopApp.Models;

namespace ShopApp.Data
{
	public class ApplicationDbContext : IdentityDbContext<AppUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
	
		}
		public DbSet<Product> Products
		{
			get;
			set;
		}
		public DbSet<AppUser> User
		{
			get;
			set;
		}
		public DbSet<Cart> Carts
		{
			get;
			set;
		}
		public DbSet<Cart_Totals> Cart_Totals
		{
			get;
			set;
		}
		public DbSet<Inv_Totals> Inv_Totals
		{
			get;
			set;
		}
	}
}
