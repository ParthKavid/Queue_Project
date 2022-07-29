using Dapper;
using Queue_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Queue_Project.DAL
{
    public class Patient_DAL : dbConnection
    {
        public List<Patient_Model> GetPatientsDetail()
        {
            try
            {
                var param = new {
                    Method = "GetPatientsDetail"
                };

                connection();
                var PatientList = con.Query<Patient_Model>("Proc_Patient", param, commandType: CommandType.StoredProcedure).ToList();

                return PatientList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                con.Close();
            }

        }
    }
}