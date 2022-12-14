using System.Configuration;
using System.Runtime.ExceptionServices;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
       
        double num1;
        double num2;
        String option;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void n1_Click(object sender, EventArgs e)
        {
           
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
         
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
          
            {
                textBox1.Text = textBox1.Text + "3";
            }

        }

        private void n4_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = (textBox1.Text + "4");
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
           
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
           
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
           
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
           
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            option = "+";
            if (!string.IsNullOrEmpty(textBox1.Text))
            { 
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
                }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            //This will allow negative numbers
            if (string.IsNullOrEmpty(textBox1.Text))
            { 
                textBox1.Text += "-";
                }
            else { 
            option = "-";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
                }
        }

        private void mult_Click(object sender, EventArgs e)
        {
            option = "*";
            if (!string.IsNullOrEmpty(textBox1.Text))
            { 
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
                }
        }

        private void div_Click(object sender, EventArgs e)
        {
            option = "/";
            if (!string.IsNullOrEmpty(textBox1.Text))
            { 
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
                }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            //set the textBox to num 1 if no number in textbox
            if (string.IsNullOrEmpty(textBox1.Text))
            {
             textBox1.Text = num1.ToString();
                return;
            }

            //Number in the textbox but no option
            if(string.IsNullOrEmpty(option))
            {
                return;
            }
            num2 = double.Parse(textBox1.Text);
            switch (option)
            { 
                case "+":
                result = num1 +num2;
                break;

                case "-":
                result = num1-num2;
                break;

                case"*":
                result = num1*num2;
                break;

                case"/":
                result = num1 /num2;
                break;

                default:
                result = 0;
                break;
         }
            textBox1.Text = result.ToString();
        }

        private void c_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
            option = "";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
    }
    }

