using Dapper;
using Queue_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Queue_Project.DAL
{
    public class Doctor_DAL : dbConnection
    {
     
        public List<Doctor_Model> GetDoctorData(int? DoctorId)
        {
            
                try
                {
                    var param = new
                    {
                        Method = "GetDoctorData",
                        DoctorId = DoctorId
                    };

                    connection();
                    var DoctorData = con.Query<Doctor_Model>("Proc_Doctor", param, commandType: CommandType.StoredProcedure).ToList();

                    return DoctorData;
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

        public int SetClinicTime(string StartTime, string EndTime)
        {
            try
            {
                var param = new
                {
                    Method = "SetClinicTime",
                    StartTime = StartTime,
                    EndTime = EndTime
                    
                };

                connection();
                var data = con.Query<int>("Proc_Doctor", param, commandType: CommandType.StoredProcedure).FirstOrDefault();

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

        public List<Chart_Model> GetCharData()
        {
            try
            {
                var param = new
                {
                    Method = "GetCharData"
                    
                };

                connection();
                var DoctorData = con.Query<Chart_Model>("Proc_Chart", param, commandType: CommandType.StoredProcedure).ToList();

                return DoctorData;
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