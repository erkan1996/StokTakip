using StokTakip.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StokTakip.Controllers
{

    public class AraController : Controller
    {
        private StoktDBContext db = new StoktDBContext();
        // GET: Ara
        public ActionResult Index(int? k)
        {
            db.Configuration.LazyLoadingEnabled = false;
            var degerler = from d in db.Stok.Include("Depo") select d;
            if (k != null)
            {

                degerler = degerler.Where(x => x.StokKodu == k);


            }
      
            return View(degerler);
        }
    }
}