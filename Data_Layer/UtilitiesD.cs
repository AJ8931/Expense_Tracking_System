using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Layer
{
    public class UtilitiesD
    {
        public static double numMonths;
        public string calculateMonth(int daysPassed)
        {

            int daysInMonth = 30; // Assuming each month has 30 days

            numMonths = daysPassed / daysInMonth;
            //MessageBox.Show(daysPassed.ToString(), "asdf", MessageBoxButtons.OK);

            if (daysPassed % daysInMonth != 0)
            {
               
                numMonths++; // Include the partial month if there are remaining days
                
            }

            return "Month "+numMonths; 
        }
        public DataTable GenerateMonthTable(int daysPassed)
        {
            DataTable monthTable = new DataTable();
            monthTable.Columns.Add("Month", typeof(string));

            int daysInMonth = 30; // Assuming each month has 30 days

            numMonths = daysPassed / daysInMonth;
            if (daysPassed % daysInMonth != 0)
            {
                numMonths++; // Include the partial month if there are remaining days
            }

            for (int i = 1; i <= numMonths; i++)
            {
                DataRow row = monthTable.NewRow();
                row["Month"] = "Month " + i;
                monthTable.Rows.Add(row);
            }

            return monthTable;
        }

    }
}
