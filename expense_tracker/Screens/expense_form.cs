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
        userIncomeB_class inc = new userIncomeB_class();
        CategoriesB_Class categories = new CategoriesB_Class(); 
        UtilitiesB ut = new UtilitiesB();
        public bool chk_Man = false;
        public expense_form()
        {
            InitializeComponent();
        }
        public void gridUI()
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[3].Visible = false;
            cmbCategory.DataSource = categories.getCategories();
            cmbCategory.DisplayMember = "category";
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        private void Expense_form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.getExpenseData(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString());
            expense.Text = "Expense: " + obj.totalPrice(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
            budget.Text = "Budget: " + inc.totalIncome(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
            gridUI();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            obj.AddExpenseData(Login.signedInToken, Convert.ToString(cmbCategory.Text), textBox1.Text, textBox4.Text, textBox3.Text, ut.MonthStringGenerator(Login.Elapsed_days), chk_Man);
            //string id, string categories, int price, int name, string detail
            dataGridView1.DataSource = obj.getExpenseData(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString());
            expense.Text = "Expense: " + obj.totalPrice(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                // Get the index of the clicked cell
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                // Display the index as a message
                MessageBox.Show($"Clicked cell index: ({rowIndex}, {columnIndex})");
        }

        private void chkMan_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMan.Checked) {
                chk_Man = true;
            }
            else
            {
                chk_Man = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            report_form report = new report_form();
            report.Show();
            this.Hide();
        }
    }
}
