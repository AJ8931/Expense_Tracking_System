using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Data_Layer
{
    public class userTotalD_class
    {

        public string ConString = userAuthD_class.ConString;
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

        public void execQuery(SqlCommand cmd)
        {
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
        public void setData(string id,string totalIncome, string totalBudget)
        {
            MessageBox.Show(totalIncome.ToString(), "as", MessageBoxButtons.OK);

           /* string query = "insert into user_total (id,totalExpense,totalBudget) values (@id,@te,@tb)";
            SqlCommand insertCmd = new SqlCommand(query);

            insertCmd.Parameters.AddWithValue("@id", id);
            insertCmd.Parameters.AddWithValue("@te", totalIncome);
            insertCmd.Parameters.AddWithValue("@tb", totalBudget);

            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            execQuery(insertCmd); */
        }
    }
}
