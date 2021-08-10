using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Config
{
    class Connection
    {
        SqlConnection con = new SqlConnection();

        private Connection()
        {
            con.ConnectionString = ConfigurationManager.AppSettings["SqlConnection"];
        }

        public SqlConnection Connecting()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
    }
}
