using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Models.Sınıf;
using PagedList;
using PagedList.Mvc;

namespace MvcCV.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index(int page = 1)
        {
           // Class1 cs = new Class1();
            var degerler = db.TBLSKILLS.ToList().ToPagedList(page, 3);
            return View(degerler);
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
        public ActionResult BringSkill(int id)
        {
            var skill = db.TBLSKILLS.Find(id);
            return View("BringSkill", skill);
        }
        public ActionResult UpdateSkill(TBLSKILLS p)
        {
            var data = db.TBLSKILLS.Find(p.ID);
            data.SKILL = p.SKILL;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}