using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        private string currentCalculation = " ";
        private double number = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;      
            textBox.Text = currentCalculation;
            label1.Text = currentCalculation;
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.ToString();

            try
            {
                  textBox.Text = new DataTable().Compute(currentCalculation, null).ToString();
                  currentCalculation= textBox.Text;
                  label1.Text = " ";
            }
           catch (Exception ex)
           {
               textBox.Text = "0";
               currentCalculation = "";
           }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
           if(currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }
            textBox.Text = label1.Text = currentCalculation;
            
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            label1.Text = " ";
            currentCalculation = " ";
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            try
            {
            number = Convert.ToDouble(currentCalculation);
            currentCalculation = Math.Sqrt(number).ToString();
            textBox.Text = currentCalculation;
            label1.Text = currentCalculation;
            }
            catch (Exception ex)
            {
                textBox.Text = "0";
                currentCalculation = "";
            }
        }
    }
}
