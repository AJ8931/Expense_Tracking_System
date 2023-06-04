using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Data_Layer
{
    public class userIncomeD_class
    {

        public string ConString = userAuthD_class.ConString;
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();

        public List<int> GetAllIncomeValues(string id, string month)
        {
            List<int> priceValues = new List<int>();

            // SQL query to retrieve all the price values
            string query = "SELECT income FROM user_income WHERE id = @id AND Month=@month";
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
                    int income = Convert.ToInt32(reader["income"]);
                    priceValues.Add(income);
                }
            }

            return priceValues;
        }

        public List<string> GetAllSourceValues(string id, string month)
        {
            List<string> sources = new List<string>();

            // SQL query to retrieve all the price values
            string query = "SELECT source FROM user_income WHERE id = @id AND Month = @month";
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
                    sources.Add(Convert.ToString(reader["source"]));
                }
            }

            return sources;
        }

        public int GetTotalIncomeSum(string id, string month)
        {
            int totalPriceSum = 0;
            // SQL query to retrieve the sum of the "price" column
            string query = "SELECT SUM(income) FROM user_income WHERE id = @id AND Month = @month";
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
        public DataTable getData(string id, string month)
        {

            SqlCommand cmd = new SqlCommand("select * from user_income where id= @id AND Month = @month", con);
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


        public void execQuery(SqlCommand cmd)
        {
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
        public void setData(string id, string source, int income, string detail, string month)
        {

            string query = "insert into user_income (id,source,income,detail,Month) values (@id,@sc,@in,@dt,@mn)";
            SqlCommand insertCmd = new SqlCommand(query);

            insertCmd.Parameters.AddWithValue("@id", id);
            insertCmd.Parameters.AddWithValue("@sc", source);
            insertCmd.Parameters.AddWithValue("@in", income);
            insertCmd.Parameters.AddWithValue("@dt", detail);
            insertCmd.Parameters.AddWithValue("@mn", month);

            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            execQuery(insertCmd);
        }


    }
}
