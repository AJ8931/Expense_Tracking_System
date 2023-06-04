using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class CategoriesB_Class
    {
        CategoriesD_class obj = new CategoriesD_class();

        public DataTable getCategories()
        {
            return obj.getCategory();
        }
    }
}
