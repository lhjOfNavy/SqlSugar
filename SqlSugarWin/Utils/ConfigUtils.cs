using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarWin.Utils
{
    public class ConfigUtils
    {
        public static string ConnectionString;
        public static void Init()
        {
            ConnectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
        }

    }
}
