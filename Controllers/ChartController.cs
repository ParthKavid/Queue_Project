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
            return View();
        }


        public ActionResult GetChartData()
        {
            Doctor_DAL dd = new Doctor_DAL();
            var data = dd.GetCharData();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}