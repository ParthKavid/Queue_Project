﻿using Queue_Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Queue_Project.Controllers.Doctor
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Doctor()
        {
            Patient_DAL pdal = new Patient_DAL();
            pdal.GetPatientsDetail();
            return View();
        }
    }
}