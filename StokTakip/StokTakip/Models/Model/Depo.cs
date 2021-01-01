using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StokTakip.Models.Model
{
	[Table("Depo")]
	public class Depo
	{
		[Key]
		public int DepoId { get; set; }
		[Required]
		[DisplayName("Depo Adı")]
		public string DepoAdi { get; set; }
		[Required]
		[DisplayName("Depo Adres")]
		public string DepoAdres { get; set; }

		[Required]
		[DisplayName("Telefon No")]
		public string TelNo { get; set; }
		public ICollection<Stok> Stoks { get; set; }


	}
}