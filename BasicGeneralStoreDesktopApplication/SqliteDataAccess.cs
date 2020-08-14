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

        public static Item getItemByID(int id)
        {
            using (IDbConnection dbConnection = new SQLiteConnection(getConnectionString()))
            {
                return dbConnection.Query<Item>("SELECT * FROM Item WHERE ID = @ID", new { ID = id}).Single();
            }
        }

        public static void SaveItem(Item item)
        {
            using (IDbConnection dbConnection = new SQLiteConnection(getConnectionString()))
            {
                dbConnection.Execute("INSERT INTO Item (Name, BuyingPrice, SellingPrice, Quantity, Unit) VALUES( @Name, @BuyingPrice, @SellingPrice, @Quantity, @Unit ); ", item);
            }
        }

        public static void DeleteItemByID(int id)
        {
            using (IDbConnection dbConnection = new SQLiteConnection(getConnectionString()))
            {
                dbConnection.Execute("DELETE FROM Item WHERE [ID] = @ID;", new Item() { ID = id });
            }
        }

        public static void UpdateItemByID(Item item)
        {
            using (IDbConnection dbConnection = new SQLiteConnection(getConnectionString()))
            {
                dbConnection.Execute("UPDATE Item SET Name = @Name, BuyingPrice=@BuyingPrice, SellingPrice =@SellingPrice, Quantity=@Quantity, Unit=@Unit, UpdatedOn = datetime(CURRENT_TIMESTAMP, 'localtime') WHERE ID = @ID;", item);
            }
        }

        public static List<Item> getItemsByName(String text)
        {
            using (IDbConnection dbConnection = new SQLiteConnection(getConnectionString()))
            {
                //TODO: Fix this, this could cause SQL Injection!
                String query = "SELECT * FROM Item WHERE Name LIKE '%" + text + "%';";
                return dbConnection.Query<Item>(query).ToList();
            }
        }
    }
}
