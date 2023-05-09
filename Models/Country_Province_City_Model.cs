using Queue_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Queue_Project.Models
{
    
    public class CountryMaster_Model
    {
        private static DbEntityContext db = new DbEntityContext();

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public static IEnumerable<SelectListItem> GetCountryData()
        {
            var CountryData = (from item in db.tbl_CountryMaster.ToList()
                               select new SelectListItem()
                               {
                                   Text = item.CountryName,
                                   Value = item.CountryId.ToString()
                               }).ToList();

            return CountryData;
        }
    }

    public class ProvinceMaster_Model
    {
        private static DbEntityContext db = new DbEntityContext();

        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public int CountryId { get; set; }

        public static IEnumerable<SelectListItem> GetProvinceData(int CountryId)
        {
            var ProvinceData = (from item in db.tbl_ProvinceMaster.Where(x => x.CountryId == CountryId).ToList()
                                select new SelectListItem()
                                {
                                    Text = item.ProvinceName,
                                    Value = item.ProvinceId.ToString()
                                });

            return ProvinceData;
        }
    }

    public class CityMaster_Model
    {
        private static DbEntityContext db = new DbEntityContext();

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int ProvinceId { get; set; }


        public static IEnumerable<SelectListItem> GetCityData(int ProvinceId)
        {
            var CityData = (from item in db.tbl_CityMaster.Where(x => x.ProvinceId == ProvinceId).ToList()
                            select new SelectListItem()
                            {
                                Text = item.CityName,
                                Value = item.CityId.ToString()
                            }).ToList();

            return CityData;
        }
    }
}