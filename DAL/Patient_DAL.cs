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

        public int NotAttend(int TokenId)
        {
            try
            {
                var param = new
                {
                    Method = "NotAttend",
                    TokenId = TokenId
                };

                connection();
                var data = con.Query<int>("Proc_Token", param, commandType: CommandType.StoredProcedure).FirstOrDefault();

                if (data == null)
                {
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

        public int CancelPatient(int TokenId)
        {
            try
            {
                var param = new
                {
                    Method = "CancelPatient",
                    TokenId = TokenId
                };

                connection();
                var data = con.Query<int>("Proc_Token", param, commandType: CommandType.StoredProcedure).FirstOrDefault();

                if (data == null)
                {
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
       

        public List<Token_Model> GetVisitedPatients(DateTime dateval)
        {
            try
            {
                var param = new
                {
                    Method = "GetVisitedPatients",
                    DateVal = dateval
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

        public int GetNextPatient(int TokenId)
        {
            try
            {
                var param = new
                {
                    Method = "GetNextPatient",
                    TokenId = TokenId
                };

                connection();
                var data = con.Query<int>("Proc_Token", param, commandType: CommandType.StoredProcedure).FirstOrDefault();

                if (data == null)
                {
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

        //public List<Patient_Model> GetPatientsDetail()
        //{
        //    try
        //    {
        //        var param = new {
        //            Method = "GetPatientsDetail"
        //        };

        //        connection();
        //        var PatientList = con.Query<Patient_Model>("Proc_Patient", param, commandType: CommandType.StoredProcedure).ToList();

        //        return PatientList;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally {
        //        con.Close();
        //    }

        //}
    }
}