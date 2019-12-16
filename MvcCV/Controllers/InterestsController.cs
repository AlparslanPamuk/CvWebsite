using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Models.Sınıf;

namespace MvcCV.Controllers
{
    public class InterestsController : Controller
    {
        // GET: Interests
        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger5 = db.TBLINTERESTS.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult NewInterest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewInterest(TBLINTERESTS p)
        {
            db.TBLINTERESTS.Add(p);
            db.SaveChanges();
            return View(p);
        }
        public ActionResult DeleteInterest(int id)
        {
            var interest = db.TBLINTERESTS.Find(id);
            db.TBLINTERESTS.Remove(interest);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BringInterest(int id)
        {
            var interest = db.TBLINTERESTS.Find(id);
            return View("BringInterest", interest);
        }
        public ActionResult UpdateInterest(TBLINTERESTS p)
        {
            var data = db.TBLINTERESTS.Find(p.ID);
            data.INTEREST = p.INTEREST;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
    
    
    
}