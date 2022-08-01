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

        
        public int CancelTokenData(string phone)
        {
            try
            {
                var param = new
                {
                    Method = "CancelTokenData",
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

        
        public string CheckTokenData(string phone)
        {
            try
            {
                var param = new
                {
                    Method = "CheckTokenData",
                    Phone = phone
                };

                connection();
                var data = con.Query<string>("Proc_Token", param, commandType: CommandType.StoredProcedure).FirstOrDefault();

                if (data == null)
                {
                    data = "";
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
    }
}