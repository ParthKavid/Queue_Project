using Queue_Project.DAL;
using Queue_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Queue_Project.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Chart()
        {
            Chart_Model model = new Chart_Model();
            model.DateVal = DateTime.Now.ToString("yyyy-MM-dd");
            return View(model);
        }


        public ActionResult GetChartData()
        {
            Doctor_DAL dd = new Doctor_DAL();
            var data = dd.GetCharData();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetVisitedPatients(DateTime dateval)
        {
            var data = ClsObject_Creation.Patient_obj.GetVisitedPatients(dateval);
            return Json(data,JsonRequestBehavior.AllowGet);
        }
    }
}