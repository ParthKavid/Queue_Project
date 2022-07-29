using Queue_Project.DAL;
using Queue_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Queue_Project.Controllers.Patient
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Patient()
        {
            
            return View();
        }

        public ActionResult TokenDetail()
        {
            Token_DAL tokenDAL = new Token_DAL();
            var tokenData = tokenDAL.GetTokenDetail();

            return Json(tokenData, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult SaveToken(string patientName, string phone)
        {
            var id = new Token_DAL().SaveTokenData(patientName, phone);

            return RedirectToAction("Patient");
        }
    }
}