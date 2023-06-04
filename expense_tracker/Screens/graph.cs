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
using System.Windows.Forms.DataVisualization.Charting;

namespace expense_tracker.Screens
{
    public partial class graph : template_form
    {
        public graph()
        {
            InitializeComponent();
        }
        userExpenseB_class obj = new userExpenseB_class();
        userIncomeB_class inc = new userIncomeB_class();
        UtilitiesB ut = new UtilitiesB();

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void graph_Load(object sender, EventArgs e)
        {
            DataTable months = ut.MonthList(Login.Elapsed_days);

            cmbMonth.DataSource = months;
            cmbMonth.DisplayMember = "Month";
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            ChartUI();

        }
        public void ChartUI()
        {
            income.Text = inc.totalIncome(Login.signedInToken, Convert.ToString(cmbMonth.Text)).ToString();
            expense.Text = obj.totalPrice(Login.signedInToken,Convert.ToString(cmbMonth.Text)).ToString();
            chart3.Series.Clear();
                

            // Create a new series for the chart
            Series series = new Series("Income vs Expense");
            series.ChartType = SeriesChartType.Column;

            // Add data points to the series
            series.Points.AddXY("Income", inc.totalIncome(Login.signedInToken, Convert.ToString(cmbMonth.Text)));
            series.Points.AddXY("Expense", obj.totalPrice(Login.signedInToken, Convert.ToString(cmbMonth.Text)));

            // Prepare data for the pie graph
            List<int> priceList = obj.GetAllPrice(Login.signedInToken, Convert.ToString(cmbMonth.Text));
            List<string> labels = obj.GetAllCategories(Login.signedInToken, Convert.ToString(cmbMonth.Text));


            // Bind the data to the Chart control
            chart1.Series[0].Points.DataBindXY(labels, priceList);
            chart1.Legends[0].Enabled = true;
            // Prepare data for the pie graph
            List<int> incomes = inc.GetAllIncome(Login.signedInToken, Convert.ToString(cmbMonth.Text));
            List<string> sources = inc.GetAllSource(Login.signedInToken, Convert.ToString(cmbMonth.Text));

            // Bind the data to the Chart control
            chart2.Series[0].Points.DataBindXY(sources, incomes);
            chart2.Legends[0].Enabled = true;

            // Add the series to the chart
            chart3.Series.Add(series);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Menu M = new Menu();
            M.Show();
            this.Hide();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartUI();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
