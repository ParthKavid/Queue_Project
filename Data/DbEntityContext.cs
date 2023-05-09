using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Queue_Project.Data
{
    public class DbEntityContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DbEntityContext() : base("name=myConnection")
        {
        }

        public System.Data.Entity.DbSet<Queue_Project.Models.DoctorRegistration_Model> DoctorRegistration_Model { get; set; }

        public System.Data.Entity.DbSet<Queue_Project.Models.CountryMaster_Model> tbl_CountryMaster { get; set; }

        public System.Data.Entity.DbSet<Queue_Project.Models.ProvinceMaster_Model> tbl_ProvinceMaster { get; set; }

        public System.Data.Entity.DbSet<Queue_Project.Models.CityMaster_Model> tbl_CityMaster { get; set; }
    }
}
