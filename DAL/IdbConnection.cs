using System.Data.SqlClient;

namespace Queue_Project.DAL
{
    public interface IdbConnection
    {
        void connection();
        SqlConnection Newconnection();
    }
}