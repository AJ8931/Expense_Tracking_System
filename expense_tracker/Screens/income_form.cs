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
    public partial class income_form : template_form
    {
        public income_form()
        {
            InitializeComponent();
        }

        private void Income_form_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Hide();
        }
    }
}
