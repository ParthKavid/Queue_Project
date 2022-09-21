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
            return View();
        }

        public ActionResult GetNextPatient(int TokenId)
        {
            int id = ClsObject_Creation.Patient_obj.GetNextPatient(TokenId);
            return Json(id, JsonRequestBehavior.AllowGet);
        }

        public ActionResult NotAttend(int TokenId)
        {
            int id = ClsObject_Creation.Patient_obj.NotAttend(TokenId);
            return Json(id, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CancelPatient(int TokenId)
        {
            int id = ClsObject_Creation.Patient_obj.CancelPatient(TokenId);
            return Json(id, JsonRequestBehavior.AllowGet);
        }

        public ActionResult MarkIsAttended(int TokenId)
        {
            int id = ClsObject_Creation.Token_obj.MarkIsAttended(TokenId);
            return Json(id, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SetClinicTime(string StartTime, string EndTime)
        {
            var id = ClsObject_Creation.Doctor_obj.SetClinicTime(StartTime,EndTime);
            return Json(id,JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetDoctorData(int? DoctorId)
        {
            var data = ClsObject_Creation.Doctor_obj.GetDoctorData(DoctorId);
            return Json(data,JsonRequestBehavior.AllowGet);
        }
    }
}