﻿using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Views.Admin
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }
        
        // GET: Insurees
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

    }
}