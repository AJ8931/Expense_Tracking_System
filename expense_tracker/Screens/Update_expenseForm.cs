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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace expense_tracker.Screens
{
    
    public partial class Update_expenseForm : template_form
    {

        private string category;
        private string month;
        private int price;
        private string name;
        private string details;
        private bool mandatory;
        private bool mandatoryC;

        expense_form expF = new expense_form();
        userExpenseB_class obj = new userExpenseB_class();

        public Update_expenseForm(string category, int price, string name, string detail, string month, bool mandatory)
        {
            InitializeComponent();

            // Store the passed values in the class variables
            this.category = category;
            this.price = price;
            this.name = name;
            this.details = detail;
            this.month = month;
            this.mandatory = mandatory;
        }

        private void Update_expenseForm_Load(object sender, EventArgs e)
        {
            // Use the stored values to initialize the form controls
            ctg.Text = category;
            prc.Text = price.ToString();
            nme.Text = name;
            dtls.Text = details;
            months.Text = month;
            if (mandatory)
            {
                chk_man.Checked = mandatory;
            }
            else
            {
                chk_man.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool check = obj.updateExpensesData(Login.signedInToken, ctg.Text, nme.Text, dtls.Text, prc.Text, category, month, price, mandatoryC);
            if (check)
            {
                this.Hide();
                expF.Show();
            }
        }

        private void chk_man_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_man.Checked)
            {
                mandatoryC = true;
            }
            else
            {
                mandatoryC = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            expF.Show();
        }
    }
}
