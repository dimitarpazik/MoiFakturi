using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FakturiFirst;

namespace FakturiFirst.Controllers
{
    public class FakturasController : Controller
    {
        private MoiFakturiEntities db = new MoiFakturiEntities();

        // GET: Fakturas
        public ActionResult Index()
        {
            var fakturas = db.Fakturas.Include(f => f.Client).Include(f => f.Firm);
            return View(fakturas.ToList());
        }

        // GET: Fakturas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faktura faktura = db.Fakturas.Find(id);
            if (faktura == null)
            {
                return HttpNotFound();
            }
            return View(faktura);
        }

        // GET: Fakturas/Create
        public ActionResult Create()
        {
            ViewBag.Client_ID = new SelectList(db.Clients, "Client_ID", "Client_Name");
            ViewBag.Firm_ID = new SelectList(db.Firms, "Firm_ID", "Firm_Name");
            return View();
        }

        // POST: Fakturas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Faktura_ID,Firm_ID,Client_ID,Faktura_Status,Faktura_Suma,Faktura_DatumIzdavanje,Faktura_DatumDospevanje,Faktura_TotalDDV,Faktura_Zabeleska")] Faktura faktura)
        {
            if (ModelState.IsValid)
            {
                db.Fakturas.Add(faktura);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Client_ID = new SelectList(db.Clients, "Client_ID", "Client_Name", faktura.Client_ID);
            ViewBag.Firm_ID = new SelectList(db.Firms, "Firm_ID", "Firm_Name", faktura.Firm_ID);
            return View(faktura);
        }

        // GET: Fakturas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faktura faktura = db.Fakturas.Find(id);
            if (faktura == null)
            {
                return HttpNotFound();
            }
            ViewBag.Client_ID = new SelectList(db.Clients, "Client_ID", "Client_Name", faktura.Client_ID);
            ViewBag.Firm_ID = new SelectList(db.Firms, "Firm_ID", "Firm_Name", faktura.Firm_ID);
            return View(faktura);
        }

        // POST: Fakturas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Faktura_ID,Firm_ID,Client_ID,Faktura_Status,Faktura_Suma,Faktura_DatumIzdavanje,Faktura_DatumDospevanje,Faktura_TotalDDV,Faktura_Zabeleska")] Faktura faktura)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faktura).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Client_ID = new SelectList(db.Clients, "Client_ID", "Client_Name", faktura.Client_ID);
            ViewBag.Firm_ID = new SelectList(db.Firms, "Firm_ID", "Firm_Name", faktura.Firm_ID);
            return View(faktura);
        }

        // GET: Fakturas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faktura faktura = db.Fakturas.Find(id);
            if (faktura == null)
            {
                return HttpNotFound();
            }
            return View(faktura);
        }

        // POST: Fakturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Faktura faktura = db.Fakturas.Find(id);
            db.Fakturas.Remove(faktura);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
