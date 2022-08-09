using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = AmountTextBox.Text + "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = AmountTextBox.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = AmountTextBox.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = AmountTextBox.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = AmountTextBox.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = AmountTextBox.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = AmountTextBox.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = AmountTextBox.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = AmountTextBox.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = AmountTextBox.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AmountTextBox.Text = AmountTextBox.Text + ".";
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            SubTotalTextBox.Text = AmountTextBox.Text;
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(AmountTextBox.Text) <= 100)
            {
                double amount = Convert.ToDouble(AmountTextBox.Text);
                double tax2 = amount * 0.05;
                TaxTextBox.Text = tax2.ToString("0.00");
                double total = amount + tax2;
                TotalTextBox.Text = total.ToString("0.00");
               
            }
            else if (Convert.ToDouble(AmountTextBox.Text) >= 100 && Convert.ToDouble(AmountTextBox.Text) < 499)
            {
                double amount = Convert.ToDouble(AmountTextBox.Text);
                double tax2 = amount * 0.075;
                TaxTextBox.Text = tax2.ToString("0.00");
                double total = amount + tax2;
                TotalTextBox.Text = total.ToString("0.00");
            }
            else if (Convert.ToDouble(AmountTextBox.Text) > 499)
            {
                double amount = Convert.ToDouble(AmountTextBox.Text);
                double tax2 = amount * 0.10;
                TaxTextBox.Text = tax2.ToString("0.00");
                double total = amount + tax2;
                TotalTextBox.Text = total.ToString("0.00");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            AmountTextBox.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            AmountTextBox.Clear();
            SubTotalTextBox.Clear();
            TaxTextBox.Clear();
            TotalTextBox.Clear();
        }
    }
}
