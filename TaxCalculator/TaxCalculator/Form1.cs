using System;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        const double Tax = 0.1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double itemCost;
            double itemTax;
            double total;

            try
            {
                itemCost = double.Parse(itemCostTextBox.Text);
                itemTax = itemCost * Tax;
                total = itemCost + itemTax;

                itemCostTextBox.Text = itemCost.ToString("c");
                taxOutputBox.Text = itemTax.ToString("c");
                totalOutputBox.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            itemCostTextBox.Text = "";
            taxOutputBox.Text = "";
            totalOutputBox.Text = "";
        }
    }
}
