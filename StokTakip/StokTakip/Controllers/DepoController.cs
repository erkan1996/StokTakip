using StokTakip.Models.DataContext;
using StokTakip.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StokTakip.Controllers
{
    public class DepoController : Controller
    {
        private StoktDBContext db = new StoktDBContext();
        // GET: Depo
        public ActionResult Index()
        {

            return View(db.Depo.ToList());
        }
        public ActionResult Create()
		{
            return View();
		}
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Depo depo)
        {
            db.Depo.Add(depo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
		{
            if (id == null)
            {
                return HttpNotFound();
            }

            var d = db.Depo.Where(x => x.DepoId == id).SingleOrDefault();
            return View(d);
		}
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Depo depo)
		{
            if (ModelState.IsValid)
            {        
                var d = db.Depo.Where(x => x.DepoId == id).SingleOrDefault();
                d.DepoAdi = depo.DepoAdi;
                d.DepoAdres = depo.DepoAdres;
                d.TelNo = depo.TelNo;
               db.SaveChanges();
               return RedirectToAction("Index");
            }
        
            return View(depo);
		}
        public ActionResult Delete(int? id)
        {

            var d = db.Depo.Find(id);
            if (d == null)
            {
                return HttpNotFound();
            }
        

            db.Depo.Remove(d);
            db.SaveChanges();
            return RedirectToAction("Index");

        }



    }
}