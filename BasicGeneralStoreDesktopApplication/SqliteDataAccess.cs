using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicGeneralStoreDesktopApplication.Model;

namespace BasicGeneralStoreDesktopApplication
{
    public class SqliteDataAccess
    {
        public static String getConnectionString(String name = "Default")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static List<Item> getAllItems()
        {
            return null;
        }

    }
}
