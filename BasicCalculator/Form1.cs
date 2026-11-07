using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicCalculator; 

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);
                float result = 0;

               
                string selectedOperator = comboBox1.SelectedItem.ToString();

               
                switch (selectedOperator)
                {
                    case "+":
                        result = BasicComputation.Addition(num1, num2);
                        break;
                    case "-":
                        result = BasicComputation.Subtraction(num1, num2);
                        break;
                    case "*":
                        result = BasicComputation.Multiplication(num1, num2);
                        break;
                    case "/":
                        result = BasicComputation.Division(num1, num2);
                        break;
                    default:
                        MessageBox.Show("Please select a valid operator (+, -, *, /)");
                        return;
                }

               
                label1.Text = result.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers and select an operator. Error: " + ex.Message);
            }
        }
    }
}