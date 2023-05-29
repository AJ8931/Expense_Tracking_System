using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Layer
{
    public class userExpenseB_class
    {

        userExpenseD_class obj = new userExpenseD_class();

        public void AddExpenseData(string id, string categories, string price, string name, string detail)
        {
            if (!Regex.Match(price, @"^[0-9]{1,}$").Success)
            {
                MessageBox.Show("The price field must contain number", "validation", MessageBoxButtons.OK);
            }
            else
            {
                int priceInInt = Int32.Parse(price);
            obj.setData( id, categories, priceInInt,  name,  detail);
            }
        }

        public DataTable getExpenseData(string id)
        {
            return obj.getData(id);
        }

    }
}
