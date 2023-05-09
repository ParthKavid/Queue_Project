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

        public List<Token_Model> DashBoardPatientData(int PatientId)
        {
            try
            {
                var param = new
                {
                    Method = "DashBoardPatientAPI",
                    PatientId = PatientId
                };

                connection();
                var data = con.Query<Token_Model>("Proc_TokenAPI", param, commandType: CommandType.StoredProcedure).ToList();

                if (data == null)
                {
                    data = new List<Token_Model>();
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

        public List<Patient_Model> GetPatientsDetail(int PatientId)
        {
            try
            {
                var param = new
                {
                    Method = "GetPatientsDetail",
                    PatientId = PatientId
                };

                connection();
                var PatientList = con.Query<Patient_Model>("Proc_Patient", param, commandType: CommandType.StoredProcedure).ToList();

                return PatientList;
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


        public List<SubPatient_Model> SubPatientDetailAPI(int PatientId)
        {
            try
            {
                var param = new
                {
                    Method = "GetSubPatientDetail",
                    PatientId = PatientId
                };

                connection();
                var SubPatientList = con.Query<SubPatient_Model>("Proc_Patient", param, commandType: CommandType.StoredProcedure).ToList();

                return SubPatientList;
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

        public int SaveTokenAPI(SaveTokenModel model)
        {
            try
            {
                var param = new
                {
                    Method = "SaveTokenAPI",
                    NoOfPatient = model.NoOfPatient,
                    PatientId = model.PatientId
                };

                connection();
                var id = con.ExecuteScalar<int>("Proc_Patient", param, commandType: CommandType.StoredProcedure);


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


        public int SaveSubPatientName(SubPatient_Model model)
        {
            try
            {
                var param = new
                {
                    Method = "SaveSubPatientName",
                    FullName = model.FullName,
                    SubPatientId = model.SubPatientId
                };

                connection();
                var id = con.ExecuteScalar<int>("Proc_Patient", param, commandType: CommandType.StoredProcedure);


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