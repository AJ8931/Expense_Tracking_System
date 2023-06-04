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
        UtilitiesB ut = new UtilitiesB();

        public income_form()
        {
            InitializeComponent();
        }
        userExpenseB_class exp = new userExpenseB_class();

        private void Income_form_Load(object sender, EventArgs e)
        {
            expense.Text = "Expense: " + exp.totalPrice(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
            budget.Text = "Budget: " + obj.totalIncome(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
            dataGridView1.DataSource = obj.getIcomeData(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            obj.AddIncomeData(Login.signedInToken,textBox1.Text,textBox2.Text,textBox3.Text, ut.MonthStringGenerator(Login.Elapsed_days));
            
            dataGridView1.DataSource = obj.getIcomeData(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            report_form report = new report_form();
            report.Show();
            this.Hide();
        }
    }
}
