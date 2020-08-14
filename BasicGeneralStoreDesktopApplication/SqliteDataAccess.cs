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
            //TODO: Fix the connectionString issue
            return @"Data Source=.\DefaultDatabase.db3;Version=3;";
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static List<Item> getAllItems()
        {
            using (IDbConnection dbConnection = new SQLiteConnection(getConnectionString()))
            {
                var output = dbConnection.Query<Item>("SELECT * FROM Item;", new DynamicParameters());
                return output.ToList();
            }
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
