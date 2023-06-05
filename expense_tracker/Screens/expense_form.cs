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
            dataGridView1.AllowUserToAddRows = false;
            cmbCategory.DataSource = categories.getCategories();
            cmbCategory.DisplayMember = "category";
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public void AddGridButtons()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Update";
            buttonColumn.Name = "Update";
            buttonColumn.Text = "Update";
            buttonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.HeaderText = "Delete";
            buttonColumn2.Name = "Delete";
            buttonColumn2.Text = "Delete";
            buttonColumn2.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dataGridView1.Columns.Add(buttonColumn);
            dataGridView1.Columns.Add(buttonColumn2);
        }


        private void Expense_form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.getExpenseData(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString());
            expense.Text = "Expense: " + obj.totalPrice(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
            budget.Text = "Budget: " + inc.totalIncome(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
            gridUI();
            AddGridButtons();
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

        public void reload()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = obj.getExpenseData(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString());
            expense.Text = "Expense: " + obj.totalPrice(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
            budget.Text = "Budget: " + inc.totalIncome(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
            gridUI();
            AddGridButtons();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex == 8)  // Check if a valid row is clicked (excluding header row)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // Access the data from the cells in the selected row
                string value1 = selectedRow.Cells["categories"].Value.ToString();
                int value2 = (int)selectedRow.Cells["price"].Value;
                string value3 = selectedRow.Cells["name"].Value.ToString();
                string value4 = selectedRow.Cells["detail"].Value.ToString();
                string value5 = selectedRow.Cells["Month"].Value.ToString();
                string value6 = selectedRow.Cells["Mandatory"].Value.ToString();
                bool mandatory = Convert.ToBoolean(value6);

                Update_expenseForm updateIncomeForm = new Update_expenseForm(value1, value2, value3, value4, value5, mandatory);
                updateIncomeForm.Show();
                this.Hide();
            }
            else if (e.ColumnIndex == 9)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // Access the data from the cells in the selected row
                string value1 = selectedRow.Cells["categories"].Value.ToString();
                int value2 = (int)selectedRow.Cells["price"].Value;
                string value3 = selectedRow.Cells["Month"].Value.ToString();
                string value4 = selectedRow.Cells["name"].Value.ToString();
                bool check = obj.deleteExpenseData(Login.signedInToken, value3, value1, value2, value4);
                if (check)
                {

                    MessageBox.Show("Deleted");
                    reload();
                }
            }
            else
            {

            }
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
