using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicGeneralStoreDesktopApplication.Model;
using Dapper;

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

        public static void SaveItem(Item item)
        {
            using (IDbConnection dbConnection = new SQLiteConnection(getConnectionString()))
            {
                dbConnection.Execute("INSERT INTO Item (Name, BuyingPrice, SellingPrice, Quantity, Unit) VALUES( @Name, @BuyingPrice, @SellingPrice, @Quantity, @Unit ); ", item);
            }
        }

    }
}
