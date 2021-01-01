using StokTakip.Models.DataContext;
using StokTakip.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StokTakip.Controllers
{

    public class StokController : Controller
    {
       
        private StoktDBContext db = new StoktDBContext();
        // GET: Stok
        public ActionResult Index(int? id)
        {
            db.Configuration.LazyLoadingEnabled = false;

            ViewBag.D = id;
            return View(db.Stok.Include("Depo").ToList());


            
        }
        public ActionResult DepoStok(int? id)
        {
            

            var degerler = from d in db.Stok.Include("Depo") select d;
          
            degerler = degerler.Where(x => x.DepoId == id);
			
            return View(degerler);



        }
        public ActionResult Create()
        {
            ViewBag.DepoId = new SelectList(db.Depo, "DepoId", "DepoAdi");

            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Stok stok)
        {
       
            db.Stok.Add(stok);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Edit(int id)
        {
            if (id == null)//dışardan bize boş bir id gelirse
            {
                return HttpNotFound();
            }

            var s = db.Stok.Where(x => x.StokId == id).SingleOrDefault();
            if (s == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepoId = new SelectList(db.Depo, "DepoId", "DepoAdi");

            return View(s);
        }
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Stok stok)
        {
            if (ModelState.IsValid)
			{
                var s = db.Stok.Where(x => x.StokId == id).SingleOrDefault();
                s.UrunAdi = stok.UrunAdi;
                s.StokAdi = stok.StokAdi;
                s.StokKodu = stok.StokKodu;
                s.StokAdet = stok.StokAdet;
                s.DepoId = stok.DepoId;
          
                db.SaveChanges();//kaydet
                return RedirectToAction("Index");
			}


              
            
            return View(stok);

        }
        public ActionResult Delete(int? id)
        {

            var s = db.Stok.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
          

            db.Stok.Remove(s);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}