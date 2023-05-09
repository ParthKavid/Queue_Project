using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queue_Project.Interfaces
{
    public interface ISubPatient_Model
    {
         int SubPatientId { get; set; }
        string  SubPatientFirstName { get; set; }
        string SubPatientLastName { get; set; }
        string SubPatientPhone { get; set; }
    }
}