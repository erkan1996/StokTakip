using StokTakip.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StokTakip.Models.DataContext
{
	public class StoktDBContext : DbContext
	{
		public StoktDBContext() : base("StokTakipDB")
		{ 
		}
         public DbSet<Stok> Stok { get; set; }
		public DbSet<Depo> Depo { get; set; }



	}

}
