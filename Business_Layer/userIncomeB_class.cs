﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Layer;

namespace Business_Layer
{
    public class userIncomeB_class
    {
        userIncomeD_class obj=new userIncomeD_class();

        public void AddIncomeData(string id, string source, string income, string detail)
        {
            

            if (!Regex.Match(income,@"^[0-9]{1,}$").Success)
            {
                MessageBox.Show("The income field must contain number", "validation", MessageBoxButtons.OK);
            }
            else
            {
                int incomeInInt = Int32.Parse(income) ;
                obj.setData(id, source, incomeInInt, detail);
            }
        }

        public DataTable getIcomeData(string id)
        {
            return obj.getData(id);
        }
        
    }
}
