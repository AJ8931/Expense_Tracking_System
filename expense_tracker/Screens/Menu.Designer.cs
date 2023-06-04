namespace expense_tracker.Screens
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_income = new System.Windows.Forms.Button();
            this.btn_expense = new System.Windows.Forms.Button();
            this.btn_gaph = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.name = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.expense = new System.Windows.Forms.Label();
            this.budget = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.LightCyan;
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_report.Location = new System.Drawing.Point(310, 141);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(263, 59);
            this.btn_report.TabIndex = 3;
            this.btn_report.Text = "Check Report";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_income
            // 
            this.btn_income.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_income.FlatAppearance.BorderSize = 0;
            this.btn_income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_income.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_income.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_income.Location = new System.Drawing.Point(310, 206);
            this.btn_income.Name = "btn_income";
            this.btn_income.Size = new System.Drawing.Size(263, 59);
            this.btn_income.TabIndex = 6;
            this.btn_income.Text = "Add Income";
            this.btn_income.UseVisualStyleBackColor = false;
            this.btn_income.Click += new System.EventHandler(this.Btn_income_Click);
            // 
            // btn_expense
            // 
            this.btn_expense.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_expense.FlatAppearance.BorderSize = 0;
            this.btn_expense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expense.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expense.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_expense.Location = new System.Drawing.Point(310, 271);
            this.btn_expense.Name = "btn_expense";
            this.btn_expense.Size = new System.Drawing.Size(263, 59);
            this.btn_expense.TabIndex = 7;
            this.btn_expense.Text = "Add Expense";
            this.btn_expense.UseVisualStyleBackColor = false;
            this.btn_expense.Click += new System.EventHandler(this.Btn_expense_Click);
            // 
            // btn_gaph
            // 
            this.btn_gaph.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_gaph.FlatAppearance.BorderSize = 0;
            this.btn_gaph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gaph.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gaph.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_gaph.Location = new System.Drawing.Point(310, 336);
            this.btn_gaph.Name = "btn_gaph";
            this.btn_gaph.Size = new System.Drawing.Size(263, 59);
            this.btn_gaph.TabIndex = 8;
            this.btn_gaph.Text = "Graphs";
            this.btn_gaph.UseVisualStyleBackColor = false;
            this.btn_gaph.Click += new System.EventHandler(this.btn_gaph_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_exit.Location = new System.Drawing.Point(77, 432);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(156, 38);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MintCream;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(380, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 38);
            this.button3.TabIndex = 13;
            this.button3.Text = "LOGOUT";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Tan;
            this.splitContainer1.Panel1.Controls.Add(this.name);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(591, 111);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.SplitterIncrement = 2;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 14;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(16, 44);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(160, 24);
            this.name.TabIndex = 0;
            this.name.Text = "label1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Peru;
            this.splitContainer2.Panel1.Controls.Add(this.expense);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.splitContainer2.Panel2.Controls.Add(this.budget);
            this.splitContainer2.Size = new System.Drawing.Size(380, 109);
            this.splitContainer2.SplitterDistance = 185;
            this.splitContainer2.TabIndex = 0;
            // 
            // expense
            // 
            this.expense.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense.Location = new System.Drawing.Point(11, 44);
            this.expense.Name = "expense";
            this.expense.Size = new System.Drawing.Size(160, 24);
            this.expense.TabIndex = 1;
            this.expense.Text = "label2";
            // 
            // budget
            // 
            this.budget.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budget.Location = new System.Drawing.Point(17, 44);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(160, 24);
            this.budget.TabIndex = 2;
            this.budget.Text = "label3";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 491);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_gaph);
            this.Controls.Add(this.btn_expense);
            this.Controls.Add(this.btn_income);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_income;
        private System.Windows.Forms.Button btn_expense;
        private System.Windows.Forms.Button btn_gaph;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label expense;
        private System.Windows.Forms.Label budget;
    }
}