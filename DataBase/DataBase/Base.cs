using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Base : IBase
    {
        private string connectionString = ConfigurationManager.AppSettings["SqlConnection"];

        public string key
        {
            get
            {
                foreach(PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    OptionBase option = (OptionBase)pi.GetCustomAttribute(typeof(OptionBase));
                    if(option != null && option.ChavePrimaria)
                    {
                        return Convert.ToString(pi.GetValue(this));
                    }
                }
                return null;
            }
        }

        public virtual void Salvar()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> campos = new List<string>();
                List<string> valores = new List<string>();

                foreach(PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    OptionBase option = (OptionBase)pi.GetCustomAttribute(typeof(OptionBase));
                    if (option != null && option.UsarNoBancoDeDados)
                    {
                        campos.Add(pi.Name);
                        valores.Add("'" + pi.GetValue(this) + "'");
                    }
                }

                string queryString = "insert into " + this.GetType().Name +
            }
        }
    }
}
