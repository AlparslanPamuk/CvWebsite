using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Models.Sınıf;

namespace MvcCV.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger4 = db.TBLSKILLS.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult NewSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewSkill(TBLSKILLS p)
        {
            db.TBLSKILLS.Add(p);
            db.SaveChanges();
            return View(p);
        }
        public ActionResult DeleteSkill(int id)
        {
            var skill = db.TBLSKILLS.Find(id);
            db.TBLSKILLS.Remove(skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}