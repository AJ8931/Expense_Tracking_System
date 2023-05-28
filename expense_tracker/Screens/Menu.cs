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
    public partial class Menu : template_form
    {
        userAuthB_class obj = new userAuthB_class();
        userTotalB_class obj1= new userTotalB_class();

        public Menu()
        {
            InitializeComponent();
        }
        public static String UserName = "Adnan";
        public static int Expense = 0000;
        public static int Budget = 0000;

        private void Menu_Load(object sender, EventArgs e)
        {
            //  name.Text = "Name: " + UserName;
            expense.Text = "Expense: $" + Expense.ToString();
            budget.Text = "Budget: $" + Budget.ToString();
            label1.Text = Login.signedInUser;
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

        private void expense_Click(object sender, EventArgs e)
        {

        }

        private void budget_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    }
