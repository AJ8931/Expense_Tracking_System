using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Data_Layer
{

    public class userAuthD_class
    {
        public string ConString = "Data Source=DESKTOP-OCJ8U5N\\SQLEXPRESS;Initial Catalog=expense_tracker_proj;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();
        public void execQuery(SqlCommand cmd)
        {
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
        public DataTable getUserData(string username, string password)
        {

            SqlCommand cmd = new SqlCommand("select * from user_info where userName= @un and password= @pd", con);
            cmd.Parameters.AddWithValue("@un", username);
            cmd.Parameters.AddWithValue("@pd", password);

            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(rd);
            return dt;
        }

        public DataTable getAllUser(string username)
        {

            SqlCommand cmd = new SqlCommand("select * from user_info where userName=@un", con);
            cmd.Parameters.AddWithValue("@un", username);

            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(rd);
            return dt;
        }


        public void setUserData(string username, string password, string id)
        {
            //checkDuplication(username, password);

           // MessageBox.Show(getUserData(username, password).Rows[0]["userName"].ToString(), "yes",MessageBoxButtons.OK);

            string query = "insert into user_info (userName,password,id) values (@un,@ps,@id)";
            SqlCommand insertCmd = new SqlCommand(query);
            
            insertCmd.Parameters.AddWithValue("@un",username);
            insertCmd.Parameters.AddWithValue("@ps",password);
            insertCmd.Parameters.AddWithValue("@id",id);

            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            execQuery(insertCmd);
        }


    }
}
