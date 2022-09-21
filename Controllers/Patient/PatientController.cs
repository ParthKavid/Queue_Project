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
            var tokenData = ClsObject_Creation.Token_obj.GetTokenDetail();
            return Json(tokenData, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult SaveToken(string patientName, string phone)
        {

            if (patientName != null && phone != null)
            {
                var id = ClsObject_Creation.Token_obj.SaveTokenData(patientName, phone);
            }

            return RedirectToAction("Patient");
        }

        [HttpPost]
        public ActionResult CancelToken(string phone)
        {
            var id = ClsObject_Creation.Token_obj.CancelTokenData(phone);

            return RedirectToAction("Patient");
        }

        
        public ActionResult CheckToken(string phone)
        {
            HttpCookie reqCookies = Request.Cookies["phoneData"];
            
            if (phone == "" && reqCookies != null)
            {
                phone = reqCookies["PhoneCookie"].ToString();
                
            }

            var tokennum = ClsObject_Creation.Token_obj.CheckTokenData(phone);
            
            HttpCookie tokenData = new HttpCookie("phoneData");

            tokenData["PhoneCookie"] = phone;
            tokenData.Expires.AddHours(12);
            Response.Cookies.Add(tokenData);

            return Json(tokennum,JsonRequestBehavior.AllowGet);
        }


    }
}