using Queue_Project.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Queue_Project.Models
{
    public class DoctorRegistration_Model : IPersonInfo, IClinicInfo
    {
        [Key]
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ClinicName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string ClinicAddress { get; set; }
        public int CountryId { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public string Zipcode { get; set; }
        public IEnumerable<CountryMaster_Model> CountryList { get; set; }
        public IEnumerable<ProvinceMaster_Model> ProvinceList { get; set; }
        public IEnumerable<CityMaster_Model> CityList { get; set; }



    }
}