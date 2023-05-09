using Queue_Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queue_Project.Models
{
    public class Patient_Model : IPersonInfo
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }

        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CountryId { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public string Zipcode { get; set; }
        public bool IsReserved { get; set; }
    }
}