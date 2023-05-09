using Queue_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Queue_Project.CommonMethods
{
    public class ClsDropdownBind
    {
        public IEnumerable<SelectListItem> CountryList(List<CountryMaster_Model> countryMaster_Models)
        {
            var drpdown = (from item in countryMaster_Models
                           select new SelectListItem
                           {
                               Text = item.CountryName,
                               Value = item.CountryId.ToString()
                           }).ToList();

            return drpdown;
        }

        public IEnumerable<SelectListItem> ProvinceList(List<ProvinceMaster_Model> provinceMaster_Models)
        {
            var drpdown = (from item in provinceMaster_Models
                           select new SelectListItem
                           {
                               Text = item.ProvinceName,
                               Value = item.ProvinceId.ToString()
                           }).ToList();

            return drpdown;
        }

        public IEnumerable<SelectListItem> CityList(List<CityMaster_Model> cityMaster_Models)
        {
            var drpdown = (from item in cityMaster_Models
                           select new SelectListItem
                           {
                               Text = item.CityName,
                               Value = item.CityId.ToString()
                           }).ToList();

            return drpdown;
        }
    }
}