using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team_20.SQL_DataBase
{
    class SQLConnection
    {

        static private string connetionStr;
        static private SqlConnection sqlConnection = null;

        public SQLConnection() // Default Connection
        {

        }

        public static  Boolean InitConnection()
        {
           connetionStr = "Data Source=tcp:sce-group20-project.database.windows.net,1433;" +
    "Initial Catalog=ProjectDataBase;Persist Security Info=True;" +
    "User ID=Group20;Password=gKrt@gyT;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(connetionStr);
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch(Exception error)
            {
                error.GetType();
                return false;
            }
        }

        public static SqlConnection GetSqlConnection()
        {
            return sqlConnection;
        }
    }
}
