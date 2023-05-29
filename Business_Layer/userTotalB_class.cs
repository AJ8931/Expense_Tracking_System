using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class userTotalB_class
    {
        userTotalD_class obj = new userTotalD_class();
        public DataTable getTotals(string id)
        {
            return obj.getData(id);
        }

        public void setTotals(string id,string totalIncome,string totalBudget) 
        {
            obj.setData(id,totalIncome,totalBudget);
        }
    }
}
