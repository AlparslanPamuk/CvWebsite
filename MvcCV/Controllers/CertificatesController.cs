﻿using System;
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
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger6 = db.TBLAWARDS.ToList();
            return View(cs);
        }
    }
}