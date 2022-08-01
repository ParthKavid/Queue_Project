using Queue_Project.DAL;
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

        public ActionResult GetNextPatient(int TokenId)
        {
            Token_DAL tokenObj = new Token_DAL();
            int id = tokenObj.GetNextPatient(TokenId);

            return Json(id,JsonRequestBehavior.AllowGet);
        }

        public ActionResult NotAttend(int TokenId)
        {
            Token_DAL tokenObj = new Token_DAL();
            int id = tokenObj.NotAttend(TokenId);

            return Json(id, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CancelPatient(int TokenId)
        {
            Token_DAL tokenObj = new Token_DAL();
            int id = tokenObj.CancelPatient(TokenId);

            return Json(id, JsonRequestBehavior.AllowGet);
        }
    }
}