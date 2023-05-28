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
    public partial class Menu : template_form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public static String UserName = "Adnan";
        public static int Expense = 150000;
        public static int Budget = 250000;

        private void Menu_Load(object sender, EventArgs e)
        {
            name.Text = "Name: " + UserName;
            expense.Text = "Expense: $" + Expense.ToString();
            budget.Text = "Budget: $" + Budget.ToString();
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
    }
    }
