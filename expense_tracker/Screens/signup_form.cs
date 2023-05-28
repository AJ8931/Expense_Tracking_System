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
    public partial class signup_form : template_form
    {
        public signup_form()
        {
            InitializeComponent();
        }

        private void Signup_form_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
