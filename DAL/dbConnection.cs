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
            string constr = ConfigurationManager.ConnectionStrings["myConnection"].ToString();
            con = new SqlConnection(constr);
            con.Open();
        }

        public SqlConnection Newconnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["myConnection"].ToString();
            con = new SqlConnection(constr);
            return con;
        }
    }
}