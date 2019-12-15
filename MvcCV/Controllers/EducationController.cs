using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Models.Sınıf;

namespace MvcCV.Controllers
{
    
    public class EducationController : Controller
    {
        // GET: Education
        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger3 = db.TBLEDUCATION.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult NewEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewEducation(TBLEDUCATION p)
        {
            db.TBLEDUCATION.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult DeleteEducation(int id)
        {
            var education = db.TBLEDUCATION.Find(id);
            db.TBLEDUCATION.Remove(education);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}