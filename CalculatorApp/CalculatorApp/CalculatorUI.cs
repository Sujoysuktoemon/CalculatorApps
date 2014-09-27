using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        Calculator aCalculator = new Calculator();

        private double firstNo;
        private double secondNo;

        private void addButton_Click(object sender, EventArgs e)
        {
            InitializeFirstNoAndSecondNo();
            MessageBox.Show(aCalculator.Add(firstNo, secondNo).ToString());
        }

        private void InitializeFirstNoAndSecondNo()
        {
            firstNo = Convert.ToDouble(firstNumberTextBox.Text);
            secondNo = Convert.ToDouble(secondNumberTextBox.Text);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            InitializeFirstNoAndSecondNo();
            MessageBox.Show(aCalculator.Subtract(firstNo, secondNo).ToString());
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            InitializeFirstNoAndSecondNo();
            try
            {
                double result = aCalculator.Divide(firstNo, secondNo);
                MessageBox.Show(result.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter non-zero as second no");

            }
            
            
        }
    }
}
