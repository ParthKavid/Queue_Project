using Queue_Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queue_Project.Models
{
    public class Doctor_Model : IPersonInfo, IClinicInfo
    {
        public string DoctorName { get; private set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string ClinicName { get; set; }
        public string ClinicAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CountryId { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public string Zipcode { get; set; }
        

        public void SetDoctorName(string fname, string lname)
        {
            this.DoctorName = fname + " "+ lname;
        }

    }

}