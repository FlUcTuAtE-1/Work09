using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_test_solid2.Helpers
{
    public class MySQLHelpers
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
        }


    }
}
