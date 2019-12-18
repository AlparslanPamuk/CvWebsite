using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Models.Sınıf;

namespace MvcCV.Controllers
{
    public class CertificatesController : Controller
    {
        // GET: Certificates
        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index(string p)
        {
            var degerler = from d in db.TBLAWARDS select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.AWARD.Contains(p));
            }
            //Class1 cs = new Class1();
           // cs.Deger6 = db.TBLAWARDS.ToList();
            return View(degerler.ToList());
        }
        [HttpGet]
        public ActionResult NewCertificate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCertificate(TBLAWARDS p)
        {
            db.TBLAWARDS.Add(p);
            db.SaveChanges();
            return View(p);
        }
        public ActionResult DeleteCertificate(int id)
        {
            var delcertificate = db.TBLAWARDS.Find(id);
            db.TBLAWARDS.Remove(delcertificate);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}