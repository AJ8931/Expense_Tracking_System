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

        public string ConString = "Data Source=DESKTOP-OCJ8U5N\\SQLEXPRESS;Initial Catalog=expense_tracker_proj;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();


        public DataTable getData(string id)
        {

            SqlCommand cmd = new SqlCommand("select * from user_income where id= @id", con);
            cmd.Parameters.AddWithValue("@id", id);

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
        public void setData(string id, string source, int income, string detail)
        {

            string query = "insert into user_income (id,source,income,detail) values (@id,@sc,@in,@dt)";
            SqlCommand insertCmd = new SqlCommand(query);

            insertCmd.Parameters.AddWithValue("@id", id);
            insertCmd.Parameters.AddWithValue("@sc", source);
            insertCmd.Parameters.AddWithValue("@in", income);
            insertCmd.Parameters.AddWithValue("@dt", detail);

            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            execQuery(insertCmd);
        }


    }
}
