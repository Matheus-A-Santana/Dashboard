using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Connection
    {
        SqlConnection con = new SqlConnection();

        //String de conexão
        public Connection()
        {
            con.ConnectionString = ConfigurationManager.AppSettings["SqlConnection"];
        }

        //Conectar
        public SqlConnection Connect()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //Desconectar
        public SqlConnection Disconnect()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
    }
}
