using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangement.Database
{
    class DataAccess
    {
       public string ConnectionString {get;set ; }
        public DataAccess()
        {
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AIUB\C#\HospitalMangement\hospital.mdf;Integrated Security=True;Connect Timeout=30";
        }
        public SqlCommand GetCommand(string sqlQuery)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            return sqlCmd;

        }
        public DataTable Execute(string sql)
        {
            SqlCommand cmd = GetCommand(sql);
            DataTable dt = Execute(cmd);
            return dt;
        }
        public DataTable Execute(SqlCommand command)
        {
            DataTable dt = new DataTable();
            command.Connection.Open();
            dt.Load(command.ExecuteReader());
            command.Connection.Close();
            return dt;
        }
        
        // var currentLocation = Directory.GetCurrentDirectory();// Returns the current file directory location
        // var projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
        // Going to the parent directory not until getting the root project path.
    }
}
