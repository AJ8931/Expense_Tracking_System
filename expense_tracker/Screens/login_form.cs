using expense_tracker.Screens.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace expense_tracker.Screens
{
    public partial class Login : template_form
    {
        userAuthB_class obj = new userAuthB_class();
        userTotalB_class obj1 = new userTotalB_class();
        public static string signedInUser { get; set; }
        public static DataTable signedInUserTotal { get; set; }

        public static string signedInToken { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

            signup_form signup = new signup_form();
            signup.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable matchedTokenNo = obj.signingIn(textBox1.Text, textBox2.Text);
            int tokenExists = matchedTokenNo.Rows.Count;

           
            if (tokenExists == 1)
            {
                string token = matchedTokenNo.Rows[0]["id"].ToString();

                // because this form is made parent to all forms so these values become global
                signedInToken = token;
                signedInUser = textBox1.Text;
                signedInUserTotal = obj1.getTotals(token);

                Menu M = new Menu();
                M.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect credentials", "Warning", MessageBoxButtons.OK);
            }


        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
