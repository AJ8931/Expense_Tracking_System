namespace expense_tracker.Screens
{
    partial class Update_expenseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nme = new System.Windows.Forms.TextBox();
            this.chk_man = new System.Windows.Forms.CheckBox();
            this.months = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctg = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.Label();
            this.prc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtls = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nme
            // 
            this.nme.Location = new System.Drawing.Point(74, 155);
            this.nme.Name = "nme";
            this.nme.Size = new System.Drawing.Size(256, 25);
            this.nme.TabIndex = 1;
            // 
            // chk_man
            // 
            this.chk_man.AutoSize = true;
            this.chk_man.Location = new System.Drawing.Point(74, 284);
            this.chk_man.Name = "chk_man";
            this.chk_man.Size = new System.Drawing.Size(91, 21);
            this.chk_man.TabIndex = 3;
            this.chk_man.Text = "Mandatory";
            this.chk_man.UseVisualStyleBackColor = true;
            this.chk_man.CheckedChanged += new System.EventHandler(this.chk_man_CheckedChanged);
            // 
            // months
            // 
            this.months.Location = new System.Drawing.Point(74, 253);
            this.months.Name = "months";
            this.months.ReadOnly = true;
            this.months.Size = new System.Drawing.Size(256, 25);
            this.months.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Month";
            // 
            // ctg
            // 
            this.ctg.Location = new System.Drawing.Point(74, 57);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(256, 25);
            this.ctg.TabIndex = 7;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(71, 37);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(61, 17);
            this.Category.TabIndex = 6;
            this.Category.Text = "Category";
            // 
            // prc
            // 
            this.prc.Location = new System.Drawing.Point(74, 106);
            this.prc.Name = "prc";
            this.prc.Size = new System.Drawing.Size(256, 25);
            this.prc.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // dtls
            // 
            this.dtls.Location = new System.Drawing.Point(74, 204);
            this.dtls.Name = "dtls";
            this.dtls.Size = new System.Drawing.Size(256, 25);
            this.dtls.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Detail";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(219, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(25, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 39);
            this.button3.TabIndex = 12;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Update_expenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 385);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtls);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctg);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.months);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chk_man);
            this.Controls.Add(this.nme);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update_expenseForm";
            this.Text = "Update_expenseForm";
            this.Load += new System.EventHandler(this.Update_expenseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nme;
        private System.Windows.Forms.CheckBox chk_man;
        private System.Windows.Forms.TextBox months;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctg;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.TextBox prc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dtls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}