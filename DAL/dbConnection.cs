using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Queue_Project.DAL
{
    public class dbConnection : IdbConnection
    {
        public SqlConnection con;
        //To Handle connection related activities      
        public void connection()
        {
            try
            {
                string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=queue;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                //if (ConfigurationManager.ConnectionStrings["myConnection"] != null)
                //{
                //    constr = ConfigurationManager.ConnectionStrings["myConnection"].ToString();
                //}
                //else {
                //    constr = System.Configuration.ConfigurationManager.AppSettings["conString"]; 
                //}
                
                con = new SqlConnection(constr);
                con.Open();
            }
            catch (Exception e )
            {
                throw e;
            }

        }

        public SqlConnection Newconnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["myConnection"].ToString();
            con = new SqlConnection(constr);
            return con;
        }
    }
}