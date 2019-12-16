using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Models.Sınıf;

namespace MvcCV.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.TBLABOUT.ToList();
            return View(cs);
        }
        public ActionResult BringData(int id)
        {
            var data = db.TBLABOUT.Find(id);
            return View("BringData", data);
        }
        public ActionResult UpdateAbout(TBLABOUT alparslan)
        {
            var mustafa = db.TBLABOUT.Find(alparslan.ID);
            mustafa.NAME = alparslan.NAME;
            mustafa.SURNAME = alparslan.SURNAME;
            mustafa.PHONE = alparslan.PHONE;
            mustafa.MAIL = alparslan.MAIL;
            mustafa.ABOUT = alparslan.ABOUT;
            db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}