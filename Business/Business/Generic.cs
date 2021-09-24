using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace Business
{
    public class Generic
    {
        DataBase.Configuration conf = new Configuration();
        public bool InitialConfig()
        {
            return conf.Config();
        }
    }
}
