using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class userIncomeB_class
    {
        userIncomeD_class obj=new userIncomeD_class();

        public void AddIncomeData(string id, string source, int income, string detail)
        {
            obj.setData(id, source, income, detail);
        }

        public DataTable getIcomeData(string id)
        {
            return obj.getData(id);
        }
        
    }
}
