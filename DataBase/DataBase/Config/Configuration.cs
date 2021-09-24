using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Configuration
    {
        private string prompt = "\\Dashboard";
        //private string queryString = "Create database ";
        private string diretorio = ConfigurationManager.AppSettings["Diretorio"];
        SqlCommand command = new SqlCommand();
        Connection con = new Connection();
        public bool Config()
        {
            return CreateDT();
        }

        private bool CreateDT()
        {
            try
            {
                string file = diretorio + prompt + ".txt";
               //string file2 = diretorio + prompt + ".txt";

                if (File.Exists(file) /*&& File.Exists(file2)*/)
                {
                    //System.IO.File.Delete(file);
                    return false;
                }
                else
                {
                   StreamWriter valor = new StreamWriter("D:/Documentos/Dashboard.mdf", true, Encoding.ASCII);
                   StreamWriter valor2 = new StreamWriter("D:/Documentos/Dashboard.ldf", true, Encoding.ASCII);
                    //System.IO.File.Create(file2);
                    return true;
                }

            }
            catch (SqlException)
            {
                //return false;
                throw;
            }
            finally
            {
                con.Disconnect();
            }
        }
    }
}
