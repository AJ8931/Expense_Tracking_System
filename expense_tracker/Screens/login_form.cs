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

namespace expense_tracker.Screens
{
    public partial class Login : template_form
    {
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

            Menu M = new Menu();
            M.Show();
            this.Hide();
        }
    }
}
