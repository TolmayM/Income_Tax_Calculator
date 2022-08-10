using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Income_Tax_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double net_income;
            double  income_tax;
            double gross_value;
            double std_deduction;
            double exemptions;
            gross_value = Convert.ToDouble(txtGross_income.Text);
            std_deduction = Convert.ToDouble(txtStd_deduction.Text);
            exemptions = Convert.ToDouble(txtExemptions.Text);
            net_income = gross_value - std_deduction - exemptions;
            income_tax = net_income * 0.15;
            lblShow.Text = "Gross income: R" + txtGross_income.Text + "\nNet income: R" + net_income.ToString() + "\nTax payable: R" + income_tax.ToString();
        }
    }
}
