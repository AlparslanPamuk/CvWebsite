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
    }
    
    
    
}