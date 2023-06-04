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

        public void AddExpenseData(string id, string categories, string price, string name, string detail, string month, bool Mandatory)
        {
            if (!Regex.Match(price, @"^[0-9]{1,}$").Success)
            {
                MessageBox.Show("The price field must contain number", "validation", MessageBoxButtons.OK);
            }
            else
            {
                int priceInInt = Int32.Parse(price);
            obj.setData( id, categories, priceInInt,  name,  detail, month, Mandatory);
            }
        }

        public DataTable getExpenseData(string id, string month)
        {
            return obj.getData(id, month);
        }

        public DataTable getMandatoryData(string id, string month)
        {
            return obj.MandatoryData(id, month);
        }
        public DataTable getUnMandatoryData(string id, string month)
        {
            return obj.UnMandatoryData(id, month);
        }

        public int totalPrice(string id, string month)
        {
            return obj.GetTotalPriceSum(id, month);
        }
        public List<int> GetAllPrice(string id, string month)
        {
            return obj.GetAllPriceValues(id, month);
        }
        public List<string> GetAllCategories(string id, string month)
        {
            return obj.GetAllCategoriesValues(id, month);
        }
    }
}
