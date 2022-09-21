using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queue_Project.Models
{
    public class Token_Model : IToken_Model, IPatient_Model
    {

        public int TokenId { get; set; }

        public int TokenNumber { get; set; }

        public DateTime Date { get; set; }

        public int PatientId { get; set; }

        public string PatientName { get; set; }

        public string Phone { get; set; }

        public bool IsPending { get; set; }

        public bool IsCancel { get; set; }
        public bool IsCurrent { get; set; }
        public bool InQueue { get; set; }

        public int Total_Remaining { get; set; }

        public int Token_Available { get; set; }

        public int Token_Running { get; set; }

        public int Total_Attended { get; set; }

        public int Total_Cancelled { get; set; }

        public int Total_NotAttended { get; set; }

        public List<IToken_Model> AllData { get; set; }




    }
}