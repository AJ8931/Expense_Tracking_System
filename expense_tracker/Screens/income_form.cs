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

        public void gridUI()
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.AllowUserToAddRows = false;

        }

        public void reload()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            expense.Text = "Expense: " + exp.totalPrice(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
            budget.Text = "Budget: " + obj.totalIncome(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
            dataGridView1.DataSource = obj.getIcomeData(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString());
            gridUI();
            AddGridButtons();
        }

        private void Income_form_Load(object sender, EventArgs e)
        {
            expense.Text = "Expense: " + exp.totalPrice(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
            budget.Text = "Budget: " + obj.totalIncome(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString()).ToString();
            dataGridView1.DataSource = obj.getIcomeData(Login.signedInToken, ut.MonthStringGenerator(Login.Elapsed_days).ToString());
            gridUI();
            AddGridButtons();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            obj.AddIncomeData(Login.signedInToken,textBox1.Text,textBox2.Text,textBox3.Text, ut.MonthStringGenerator(Login.Elapsed_days));

            reload();
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex == 5)  // Check if a valid row is clicked (excluding header row)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // Access the data from the cells in the selected row
                string value1 = selectedRow.Cells["source"].Value.ToString();
                int value2 = (int)selectedRow.Cells["income"].Value;
                string value3 = selectedRow.Cells["detail"].Value.ToString();
                string value4 = selectedRow.Cells["Month"].Value.ToString();

                Update_IncomeForm updateIncomeForm = new Update_IncomeForm(value1, value3, value2, value4);
                updateIncomeForm.Show();
                this.Hide();
                }else if(e.ColumnIndex == 6)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // Access the data from the cells in the selected row
                string value1 = selectedRow.Cells["source"].Value.ToString();
                int value2 = (int)selectedRow.Cells["income"].Value;
                string value4 = selectedRow.Cells["Month"].Value.ToString();
                bool check = obj.deleteIncomeData(Login.signedInToken, value4, value1, value2);
                if(check)
                {
                    MessageBox.Show("Deleted");
                    reload();    
                }
            }
            else
            {

            }
        }
    }
}
