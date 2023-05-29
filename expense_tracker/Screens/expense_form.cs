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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Business_Layer;

namespace expense_tracker.Screens
{
    public partial class expense_form : template_form
    {
        userExpenseB_class obj = new userExpenseB_class();
        public expense_form()
        {
            InitializeComponent();
        }

        private void Expense_form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.getExpenseData(Login.signedInToken);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.AddExpenseData(Login.signedInToken, textBox5.Text, textBox1.Text, textBox4.Text, textBox3.Text);
            //string id, string categories, int price, int name, string detail
            dataGridView1.DataSource = obj.getExpenseData(Login.signedInToken);
        }
    }
}
