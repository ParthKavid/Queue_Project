using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Queue_Project.DAL
{
    
    public class Login_Patient_DAL : dbConnection
    {
        public int Login(string firstname,string lastname, string mobileno)
        {
            
                try
                {
                    var param = new
                    {
                        Method = "LoginPatients",
                        FirstName = firstname,
                        LastName = lastname,
                        MobileNo = mobileno,

                    };

                    connection();
                    var data = con.Query<int>("Proc_Patient", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                  

                if (data == null)
                    {
                    //data = "Data not found";
                    data = 0;
                    }

                    return data;
            }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
        }
    }
}