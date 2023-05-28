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
    public partial class income_form : template_form
    {
        userIncomeB_class obj=new userIncomeB_class();

        public income_form()
        {
            InitializeComponent();
        }

        private void Income_form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.getIcomeData(Login.signedInToken);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            obj.AddIncomeData(Login.signedInToken,textBox1.Text,Int32.Parse(textBox2.Text),textBox3.Text);
            
            dataGridView1.DataSource = obj.getIcomeData(Login.signedInToken);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Hide();
        }
    }
}
