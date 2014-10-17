using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ShopApp.Data_Logic_Layers.Getway
{
    internal class ShopGetway
    {
        private SqlConnection connection;

        public ShopGetway()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        }

        public string Save(Shop aShop)
        {
            connection.Open();
            string query = "INSERT INTO t_Shop (Name,Address) VALUES(@Name, @Address)";
            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@Name",aShop.Name);
            cmd.Parameters.AddWithValue("@Address",aShop.Address);
            
            int affectedrow = cmd.ExecuteNonQuery();
            connection.Close();
            if (affectedrow > 0)
            {
                return "Shop han been created.";
            }
            return "somthing wrong";
        }


        public string GetAllItem()
        {
            string msg = "Shop Name:\t Address:\n";
            connection.Open();
            string queryShop = string.Format("SELECT * FROM t_Shop");
            SqlCommand cmdShop = new SqlCommand(queryShop, connection);
            SqlDataReader shopReader = cmdShop.ExecuteReader();
            bool HasrowShop = shopReader.HasRows;

            if (HasrowShop)
            {
                while (shopReader.Read())
                {
                    msg += "" + shopReader[1] + "\t" + shopReader[2] + "\n\n";
                }
                msg += "Product ID \t Quentity\n======================\n";
            }
            connection.Close();

            connection.Open();
            string queryItem = string.Format("SELECT * FROM t_Item");
            SqlCommand cmd = new SqlCommand(queryItem, connection);
            SqlDataReader itemReader = cmd.ExecuteReader();
            bool HasrowItem = itemReader.HasRows;

            if (HasrowItem)
            {
                while (itemReader.Read())
                {
                    msg += "" + itemReader[1] + "\t\t" + itemReader[2] + "\n";
                }
            }
            connection.Close();
            return msg;
        }


        public string Add(Item items)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Item VALUES ('{0}','{1}')", items.ItemId, items.Quantity);
            SqlCommand cmd = new SqlCommand(query, connection);
            int affectedrow = cmd.ExecuteNonQuery();
            connection.Close();
            if (affectedrow > 0)
            {
                return "Item Add sucessfully";
            }
            return "somthing wrong";

        }

        public bool HasThisItem(string itemId)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Item WHERE Item_Id={0}", itemId);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader aDataReader = cmd.ExecuteReader();
            bool Hasrow = aDataReader.HasRows;

            connection.Close();
            return Hasrow;
        }


        public string UpdateItem(Item aItem)
        {
            connection.Open();
            string query = string.Format("UPDATE t_Item SET Quentity = Quentity + {0} WHERE Item_Id={1}", aItem.Quantity, aItem.ItemId);
            SqlCommand cmd = new SqlCommand(query, connection);
            int affectedrow = cmd.ExecuteNonQuery();
            connection.Close();
            if (affectedrow > 0)
            {
                return "Item update sucessfully";
            }
            return "somthing wrong";
        }
    }
}
