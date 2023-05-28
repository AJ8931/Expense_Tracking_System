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
    public partial class signup_form : template_form
    {
        userAuthB_class obj = new userAuthB_class();

        Guid token = Guid.NewGuid();

        // Convert the token to a string

        public signup_form()
        {
            InitializeComponent();
        }

        private void Signup_form_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string tokenString = token.ToString();

            obj.signingUp(textBox1.Text,textBox2.Text,tokenString);


            DialogResult dr = MessageBox.Show("Account Created", "Signup", MessageBoxButtons.OK);

            if (dr == DialogResult.OK)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
