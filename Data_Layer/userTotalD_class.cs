using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Data_Layer
{
    public class userTotalD_class
    {

        public string ConString = "Data Source=DESKTOP-OCJ8U5N\\SQLEXPRESS;Initial Catalog=expense_tracker_proj;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();
        public DataTable getData(string id)
        {

            SqlCommand cmd = new SqlCommand("select * from user_total where id= @id", con);
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

        public void setData(string id)
        {

        }
    }
}
