using Queue_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queue_Project.DAL
{
    public static class ClsObject_Creation
    {
        public static Patient_DAL Patient_obj
        {
            get
            {
                return new Patient_DAL();
            }

            private set { }
        }

        public static Doctor_DAL Doctor_obj
        {
            get
            {
                return new Doctor_DAL();
            }

            private set { }
        }

        public static Token_DAL Token_obj
        {
            get
            {
                return new Token_DAL();
            }

            private set { }
        }
    }
}