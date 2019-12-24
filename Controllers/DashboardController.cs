using FakturiFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FakturiFirst.Controllers
{
    public class DashboardController : Controller
    {
        //MoiFakturi _db = new MoiFakturi();
        
        
        // GET: Dashboard
        public ActionResult Home()
        {
            //var model = _db.Fakturas.ToList();
            MoiFakturiEntities entities = new MoiFakturiEntities();

            return View(from Faktura in entities.Fakturas.Take(10)
                        select Faktura);
        }

        public ActionResult Clients()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            //if(_db != null)
            //{
            //    _db.Dispose();
            //}
            base.Dispose(disposing);
        }
    }
}