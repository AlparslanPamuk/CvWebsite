using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Models.Sınıf;

namespace MvcCV.Controllers
{
    public class ExperiencesController : Controller
    {
        // GET: Experiences
        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger2 = db.TBLEXPERIENCE.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult NewExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewExperience(TBLEXPERIENCE p)
        {
            db.TBLEXPERIENCE.Add(p);
            db.SaveChanges();
            //return RedirectToAction("/Experiences/Index/");
            return View();
        }
        public ActionResult DeleteExperience(int id)
        {
            var experience = db.TBLEXPERIENCE.Find(id);
            db.TBLEXPERIENCE.Remove(experience);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}