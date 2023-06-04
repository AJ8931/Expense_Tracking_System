using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class UtilitiesB
    {
        UtilitiesD ut = new UtilitiesD();
        public DataTable MonthList(int daysPassed)
        {
            return ut.GenerateMonthTable(daysPassed);
        }
        public string MonthStringGenerator(int daysPassed)
        {
            return ut.calculateMonth(daysPassed);
        }
    }
}
