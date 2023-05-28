using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class userAuthB_class
    {
        userAuthD_class obj = new userAuthD_class();
            

        public DataTable signingIn(string username,string password)
        {
            if (obj.getUserData(username, password).Rows.Count > 0)
            {
                return obj.getUserData(username, password);
            }
            else
                return new DataTable();
        }

        public void signingUp(string username, string password, string id)
        {
            obj.setUserData(username,password,id);
        }
    }
}
