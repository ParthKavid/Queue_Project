﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queue_Project.Models
{
    public class Token_Model
    {

        public int TokenId { get; set; }

        public int TokenNumber { get; set; }

        public DateTime Date { get; set; }

        public int PatientId { get; set; }

        public string PatientName  { get; set; }

        public string Phone { get; set; }

        public bool IsPending { get; set; }

        public bool IsCancel { get; set; }

        public int Token_Available { get; set; }

        public int Token_Running { get; set; }

        public List<Token_Model> AllData { get; set; }




    }
}