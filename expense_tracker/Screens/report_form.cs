using Business_Layer;
using expense_tracker.Screens.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expense_tracker.Screens
{
    public partial class report_form : template_form
    {
        public report_form()
        {
            InitializeComponent();
        }
        userExpenseB_class obj = new userExpenseB_class();
        userIncomeB_class inc = new userIncomeB_class();
        UtilitiesB ut = new UtilitiesB();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void gridUI()
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.RowHeadersVisible = false;
            datagrid_Man.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;
            datagrid_Man.RowHeadersVisible = false;
            datagrid_Man.Columns[3].Visible = false;
            dataGridView1.Columns[2].Visible = false;

        }

        private void report_form_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Today.ToString();
            txtID.Text = Login.signedInToken;
            txtName.Text = Login.signedInUser;
            DataTable months = ut.MonthList(Login.Elapsed_days);

            cmbMonth.DataSource = months;
            cmbMonth.DisplayMember = "Month";
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            loadFunc();
            gridUI();
        }
        public void loadFunc()
        {
            income.Text = inc.totalIncome(Login.signedInToken, cmbMonth.Text).ToString();
            expense.Text = obj.totalPrice(Login.signedInToken, cmbMonth.Text).ToString();
            dataGridView1.DataSource = inc.getIcomeData(Login.signedInToken, cmbMonth.Text);
            datagrid_Man.DataSource = obj.getMandatoryData(Login.signedInToken, cmbMonth.Text);
            datagrid_waste.DataSource = obj.getUnMandatoryData(Login.signedInToken, cmbMonth.Text);

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFunc();
        }

        private void graphbtn_Click(object sender, EventArgs e)
        {
            graph graph = new graph();
            graph.Show();
            this.Hide();
        }
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        { // Set the page orientation to landscape
            e.PageSettings.Landscape = true;

            // Capture the form as an image
            Bitmap bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
            DrawToBitmap(bitmap, new Rectangle(0, 0, ClientSize.Width, ClientSize.Height));

            // Draw the image on the printed page
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
    }
}
