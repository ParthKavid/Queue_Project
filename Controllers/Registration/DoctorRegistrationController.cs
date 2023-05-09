using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Queue_Project.CommonMethods;
using Queue_Project.Data;
using Queue_Project.Models;

namespace Queue_Project.Controllers.Registration
{
    public class DoctorRegistrationController : Controller
    {
        private DbEntityContext db = new DbEntityContext();

        // GET: DoctorRegistration
        public ActionResult Index()
        {
            return View(db.DoctorRegistration_Model.ToList());
        }

        // GET: DoctorRegistration/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorRegistration_Model doctorRegistration_Model = db.DoctorRegistration_Model.Find(id);
            if (doctorRegistration_Model == null)
            {
                return HttpNotFound();
            }
            return View(doctorRegistration_Model);
        }
                
        // GET: DoctorRegistration/Create
        public ActionResult Create()
        {
            //var countryData = GetCountryMaster();
            //ClsDropdownBind clsDropdownBind = new ClsDropdownBind();
            //clsDropdownBind.CountryList(countryData);
            
            return View();
        }

        // POST: DoctorRegistration/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,FirstName,LastName,Phone,Email,Password,ClinicName,StartTime,EndTime,ClinicAddress,CountryId,ProvinceId,CityId,Zipcode")] DoctorRegistration_Model doctorRegistration_Model)
        {
            if (ModelState.IsValid)
            {
                db.DoctorRegistration_Model.Add(doctorRegistration_Model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctorRegistration_Model);
        }

        // GET: DoctorRegistration/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorRegistration_Model doctorRegistration_Model = db.DoctorRegistration_Model.Find(id);
            if (doctorRegistration_Model == null)
            {
                return HttpNotFound();
            }
            return View(doctorRegistration_Model);
        }

        // POST: DoctorRegistration/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,FirstName,LastName,Phone,Email,Password,ClinicName,StartTime,EndTime,ClinicAddress,CountryId,ProvinceId,CityId,Zipcode")] DoctorRegistration_Model doctorRegistration_Model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctorRegistration_Model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctorRegistration_Model);
        }

        // GET: DoctorRegistration/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorRegistration_Model doctorRegistration_Model = db.DoctorRegistration_Model.Find(id);
            if (doctorRegistration_Model == null)
            {
                return HttpNotFound();
            }
            return View(doctorRegistration_Model);
        }

        // POST: DoctorRegistration/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DoctorRegistration_Model doctorRegistration_Model = db.DoctorRegistration_Model.Find(id);
            db.DoctorRegistration_Model.Remove(doctorRegistration_Model);
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        
        public JsonResult GetCountryMaster()
        {
            var CountryData = CountryMaster_Model.GetCountryData();
            return Json(CountryData, JsonRequestBehavior.AllowGet);
        }

        
        public JsonResult GetProvinceMaster(int CountryId)
        {
            var ProvinceData = ProvinceMaster_Model.GetProvinceData(CountryId);
            return Json(ProvinceData, JsonRequestBehavior.AllowGet);
        }

        
        public JsonResult GetCityMaster(int ProvinceId)
        {
            var CityData = CityMaster_Model.GetCityData(ProvinceId);

            return Json(CityData, JsonRequestBehavior.AllowGet);
        }


    }
}
