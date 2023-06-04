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
using System.Reflection.Emit;

namespace expense_tracker.Screens
{
    public partial class Menu : template_form
    {
        userAuthB_class obj = new userAuthB_class();
        userTotalB_class obj1= new userTotalB_class();

        public Menu()
        {
            InitializeComponent();
        }
        userExpenseB_class exp = new userExpenseB_class();
        userIncomeB_class inc = new userIncomeB_class();
        UtilitiesB ut = new UtilitiesB(); 
        private void Menu_Load(object sender, EventArgs e)
        {

            //  name.Text = "Name: " + UserName;
            expense.Text = "Expense: " + exp.totalPrice(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString());
            budget.Text = "Budget: " + inc.totalIncome(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
            name.Text = "Name: " + Login.signedInUser;
            if (Login.signedInUserTotal.Rows.Count > 0)
            {
                expense.Text = Login.signedInUserTotal.Rows[0]["totalExpense"].ToString();
                budget.Text = Login.signedInUserTotal.Rows[0]["totalBudget"].ToString();
            }
        }

        private void Btn_income_Click(object sender, EventArgs e)
        {
            income_form income = new income_form();
            income.Show();
            this.Hide();
        }

        private void Btn_expense_Click(object sender, EventArgs e)
        {
            expense_form expense = new expense_form();
            expense.Show();
            this.Hide();
        }

        private void name_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.signedInUser = "";

            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            report_form report = new report_form();
            report.Show(); 
            this.Hide();
        }

        private void btn_gaph_Click(object sender, EventArgs e)
        {
            graph graph = new graph();  
            graph.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.signedInUser = "";

            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
    }
