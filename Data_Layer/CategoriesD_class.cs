using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data_Layer
{
    public class CategoriesD_class
    {
        public string ConString = userAuthD_class.ConString;
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();
        public DataTable getCategory()
        {

            SqlCommand cmd = new SqlCommand("select * from categories", con);



            con.Close();
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(rd);
            return dt;
        }
    }
}
