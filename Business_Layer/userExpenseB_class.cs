using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class userExpenseB_class
    {

        userExpenseD_class obj = new userExpenseD_class();

        public void AddExpenseData(string id, string categories, int price, string name, string detail)
        {
            obj.setData( id, categories,  price,  name,  detail);
        }

        public DataTable getExpenseData(string id)
        {
            return obj.getData(id);
        }

    }
}
