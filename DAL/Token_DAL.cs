using Dapper;
using Queue_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Queue_Project.DAL
{
    public class Token_DAL : dbConnection
    {
        public List<Token_Model> GetTokenDetail()
        {
            try
            {
                var param = new
                {
                    Method = "GetTokenData"
                };

                connection();
                var TokenList = con.Query<Token_Model>("Proc_Token", param, commandType: CommandType.StoredProcedure).ToList();

                return TokenList;
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


        public int SaveTokenData(string patientName, string phone)
        {
            try
            {
                var param = new
                {
                    Method = "SaveTokenData",
                    PatientName = patientName,
                    Phone = phone
                };

                connection();
                var id = con.Execute("Proc_Token", param, commandType: CommandType.StoredProcedure);


                return id;
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