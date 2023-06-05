using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Linq;
using Data_Layer;
using System.Drawing;
using System.Windows.Forms;

namespace Data_Layer
{
    public class userExpenseD_class
    {

        public string ConString = userAuthD_class.ConString;
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();


        public DataTable getData(string id, string month)
        {

            SqlCommand cmd = new SqlCommand("select * from user_expense where id= @id AND Month = @month", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@month", month);

            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(rd);
            return dt;
        }

        public DataTable MandatoryData(string id, string month)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM user_expense WHERE id = @id AND Month = @month AND Mandatory = @mandatory", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@mandatory", true);

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    dt.Load(rd);
                }
            }

            return dt;
        }

        public DataTable UnMandatoryData(string id, string month)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM user_expense WHERE id = @id AND Month = @month AND Mandatory = @mandatory", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@mandatory", false);

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    dt.Load(rd);
                }
            }

            return dt;
        }

        public List<int> GetAllPriceValues(string id, string month)
        {
            List<int> priceValues = new List<int>();

            // SQL query to retrieve all the price values
            string query = "SELECT price FROM user_expense WHERE id = @id AND Month=@month";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@month", month);

            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            // Execute the query and retrieve the price values
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int price = Convert.ToInt32(reader["price"]);
                    priceValues.Add(price);
                }
            }

            return priceValues;
        }

        public List<string> GetAllCategoriesValues(string id, string month)
        {
            List<string> priceValues = new List<string>();

            // SQL query to retrieve all the price values
            string query = "SELECT categories FROM user_expense WHERE id = @id AND Month=@month";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@month", month);

            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            // Execute the query and retrieve the price values
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    priceValues.Add(Convert.ToString(reader["categories"]));
                }
            }

            return priceValues;
        }

        public int GetTotalPriceSum(string id, string month)
        {
            int totalPriceSum = 0;

            // SQL query to retrieve the sum of the "price" column
            string query = "SELECT SUM(price) FROM user_expense WHERE id = @id AND Month = @month";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@month", month);

            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            // Execute the query and retrieve the sum
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                totalPriceSum = Convert.ToInt32(result);
            }

            return totalPriceSum;
        }


        public void execQuery(SqlCommand cmd)
        {
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
        public void setData(string id,string categories, int price, string name, string detail, string month, bool Mandatory)
        {

            string query = "insert into user_expense (id,categories,price,name,detail,Month,Date,Mandatory) values (@id,@cg,@pr,@nm,@dt,@mn,@da,@man)";
            SqlCommand insertCmd = new SqlCommand(query);

            insertCmd.Parameters.AddWithValue("@id", id);
            insertCmd.Parameters.AddWithValue("@cg", categories);
            insertCmd.Parameters.AddWithValue("@pr", price);
            insertCmd.Parameters.AddWithValue("@nm", name);
            insertCmd.Parameters.AddWithValue("@dt", detail);
            insertCmd.Parameters.AddWithValue("@mn", month);
            insertCmd.Parameters.AddWithValue("@da", DateTime.Today);
            insertCmd.Parameters.AddWithValue("@man", Mandatory);

            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            execQuery(insertCmd);
        }
        public bool updateData(string id, string newCategory, string newName, string newDetail, string newprice, string category, string month, int price, bool mandatory)
        {
            string query = "UPDATE user_expense SET categories = @ct, name = @name, detail = @dt, price = @pr, Mandatory = @Mn WHERE id = @id AND categories = @category AND Month = @month AND price = @price";
            SqlCommand updateCmd = new SqlCommand(query);

            updateCmd.Parameters.AddWithValue("@ct", newCategory);
            updateCmd.Parameters.AddWithValue("@name", newName);
            updateCmd.Parameters.AddWithValue("@dt", newDetail);
            updateCmd.Parameters.AddWithValue("@pr", newprice);
            updateCmd.Parameters.AddWithValue("@id", id);
            updateCmd.Parameters.AddWithValue("@category", category);
            updateCmd.Parameters.AddWithValue("@month", month);
            updateCmd.Parameters.AddWithValue("@price", price);
            updateCmd.Parameters.AddWithValue("@Mn", mandatory);

            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            execQuery(updateCmd);
            return true;
        }

        public bool deleteData(string id, string month, string category, int price, string name)
        {
            string query = "DELETE FROM user_expense WHERE id = @id AND Month = @month AND categories = @ct AND price = @pr AND name = @nm";
            SqlCommand deleteCmd = new SqlCommand(query);

            deleteCmd.Parameters.AddWithValue("@id", id);
            deleteCmd.Parameters.AddWithValue("@month", month);
            deleteCmd.Parameters.AddWithValue("@ct", category);
            deleteCmd.Parameters.AddWithValue("@pr", price);
            deleteCmd.Parameters.AddWithValue("@nm", name);

            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            execQuery(deleteCmd);
            return true;
        }
    }
}
