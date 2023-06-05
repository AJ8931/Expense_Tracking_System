using Business_Layer;
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
    public partial class Update_IncomeForm : template_form
    {
        private string Source;
        private string detail;
        private string month;
        private int income;

        income_form incF = new income_form();
        userIncomeB_class obj = new userIncomeB_class();

        public Update_IncomeForm(string Source, string detail, int income, string month)
        {
            InitializeComponent();

            // Store the passed values in private fields
            this.Source = Source;
            this.detail = detail;
            this.income = income;
            this.month = month;
        }


        private void Update_IncomeForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Source;
            textBox2.Text = income.ToString();
            textBox3.Text = detail;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            incF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check =  obj.updateIncomeData(Login.signedInToken, income, month, Source, textBox2.Text, textBox1.Text, textBox3.Text);
            if(check)
            {
                this.Hide();
                incF.Show();
            }
        }
    }
}
