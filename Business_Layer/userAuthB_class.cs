using System;
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
    public class userAuthB_class
    {
        userAuthD_class obj = new userAuthD_class();
        public int checkDuplication(string un)
        {
            DataTable dupDt = obj.getAllUser(un);
            
            //return dupDt.Rows[1]["userName"].ToString() ;
            return dupDt.Rows.Count ;
        }
        public DataTable signingIn(string username,string password)
        {
            if (obj.getUserData(username, password).Rows.Count > 0)
            {
                return obj.getUserData(username, password);
            }
            else
                return new DataTable();
        }


        public string signingUp(string username, string password,string confirmPassword, string id, DateTime j_date)
        {
            //checks if username already exists
            if (checkDuplication(username)>0)
            {
                MessageBox.Show("Username already exists", "Warning", MessageBoxButtons.OK);
                return "userName Issue";
            }
            else
            {
                //checks regex
                if (!Regex.Match(password, @"^[a-zA-Z]{1,}[0-9]{1,}$").Success)
                {
                    MessageBox.Show("The password must include letters and numbers both", "warning", MessageBoxButtons.OK);
                    return "regex Issue";
                }
                else
                {
                    //checks if passwords miss matched
                    if (password != confirmPassword)
                    {
                        MessageBox.Show("Passwords not mathced", "warning", MessageBoxButtons.OK);
                        return "password mismatch issue";
                    }
                    else
                    {
                        obj.setUserData(username, password, id, j_date);
                        MessageBox.Show("account created", "successful", MessageBoxButtons.OK);
                        return "successful";
                    }
                }
                
            }
        }
    }
}
