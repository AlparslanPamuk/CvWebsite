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
        public ActionResult NewExperience()
        {
            return View();
        }
    }
}