using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StokTakip.Models.Model
{
	[Table("Stok")]
	public class Stok
	{
		[Key]
		public int StokId { get; set; }
		[Required]
		[DisplayName("Ürün Adı")]
		public string UrunAdi { get; set; }
		[DisplayName("Stok Adı")]
		public string StokAdi { get; set; }
		[DisplayName("Stok Kodu")]
		public int StokKodu { get; set; }
		[DisplayName("Stok Adet")]
		public int StokAdet { get; set; }
		public int? DepoId { get; set; }
		public Depo Depo { get; set; }
	}
}