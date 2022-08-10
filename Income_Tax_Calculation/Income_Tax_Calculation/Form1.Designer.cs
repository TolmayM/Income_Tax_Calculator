namespace Income_Tax_Calculation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGross_income = new System.Windows.Forms.TextBox();
            this.txtStd_deduction = new System.Windows.Forms.TextBox();
            this.txtExemptions = new System.Windows.Forms.TextBox();
            this.lblGross_income = new System.Windows.Forms.Label();
            this.lblStd_deduction = new System.Windows.Forms.Label();
            this.lblExemptions = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGross_income
            // 
            this.txtGross_income.Location = new System.Drawing.Point(132, 24);
            this.txtGross_income.Name = "txtGross_income";
            this.txtGross_income.Size = new System.Drawing.Size(118, 23);
            this.txtGross_income.TabIndex = 0;
            // 
            // txtStd_deduction
            // 
            this.txtStd_deduction.Location = new System.Drawing.Point(132, 53);
            this.txtStd_deduction.Name = "txtStd_deduction";
            this.txtStd_deduction.Size = new System.Drawing.Size(118, 23);
            this.txtStd_deduction.TabIndex = 0;
            // 
            // txtExemptions
            // 
            this.txtExemptions.Location = new System.Drawing.Point(132, 82);
            this.txtExemptions.Name = "txtExemptions";
            this.txtExemptions.Size = new System.Drawing.Size(118, 23);
            this.txtExemptions.TabIndex = 0;
            // 
            // lblGross_income
            // 
            this.lblGross_income.AutoSize = true;
            this.lblGross_income.Location = new System.Drawing.Point(12, 27);
            this.lblGross_income.Name = "lblGross_income";
            this.lblGross_income.Size = new System.Drawing.Size(82, 15);
            this.lblGross_income.TabIndex = 1;
            this.lblGross_income.Text = "Gross income:";
            // 
            // lblStd_deduction
            // 
            this.lblStd_deduction.AutoSize = true;
            this.lblStd_deduction.Location = new System.Drawing.Point(12, 56);
            this.lblStd_deduction.Name = "lblStd_deduction";
            this.lblStd_deduction.Size = new System.Drawing.Size(114, 15);
            this.lblStd_deduction.TabIndex = 1;
            this.lblStd_deduction.Text = "Standard deduction:";
            // 
            // lblExemptions
            // 
            this.lblExemptions.AutoSize = true;
            this.lblExemptions.Location = new System.Drawing.Point(12, 85);
            this.lblExemptions.Name = "lblExemptions";
            this.lblExemptions.Size = new System.Drawing.Size(105, 15);
            this.lblExemptions.TabIndex = 1;
            this.lblExemptions.Text = "Other exemptions:";
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShow.Location = new System.Drawing.Point(12, 168);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(238, 129);
            this.lblShow.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(59, 126);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(143, 27);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate income tax";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 314);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblExemptions);
            this.Controls.Add(this.lblStd_deduction);
            this.Controls.Add(this.lblGross_income);
            this.Controls.Add(this.txtExemptions);
            this.Controls.Add(this.txtStd_deduction);
            this.Controls.Add(this.txtGross_income);
            this.Name = "Form1";
            this.Text = "Income Tax Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGross_income;
        private System.Windows.Forms.TextBox txtStd_deduction;
        private System.Windows.Forms.TextBox txtExemptions;
        private System.Windows.Forms.Label lblGross_income;
        private System.Windows.Forms.Label lblStd_deduction;
        private System.Windows.Forms.Label lblExemptions;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnCalculate;
    }
}

