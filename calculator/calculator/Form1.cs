using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        int number1;
        int number2;
        int temp;

        String function = "";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (number1 == 0)
            {
                saveNumber1();
            }
            else
            {
                keepCounting();
            }
            function = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (number1 == 0)
            {
                saveNumber1();
            }
            else
            {
                keepCounting();
            }
            function = "-";
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            if (number1 == 0)
            {
                saveNumber1();
            }
            else
            {
                keepCounting();
            }
            function = "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (number1 == 0)
            {
                saveNumber1();
            }
            else
            {
                keepCounting();
            }
            function = "/";
        }

        private void buttonModel_Click(object sender, EventArgs e)
        {
            if (number1 == 0)
            {
                saveNumber1();
            }
            else
            {
                keepCounting();
            }
            function = "%";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToInt32(textBoxResult.Text);

            if (function.Equals("+"))
            {
                temp = number1 + number2;
                textBoxResult.Text = temp.ToString();
            }
            else if (function.Equals("-"))
            {
                temp = number1 - number2;
                textBoxResult.Text = temp.ToString();
            }
            else if (function.Equals("*"))
            {
                temp = number1 * number2;
                textBoxResult.Text = temp.ToString();
            }
            else if (function.Equals("/"))
            {
                temp = number1 / number2;
                textBoxResult.Text = temp.ToString();
            }
            else if (function.Equals("%"))
            {
                temp = number1 % number2;
                textBoxResult.Text = temp.ToString();
            }
            number2 = Convert.ToInt32(textBoxResult.Text);
            number1 = 0;
            function = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        void buttonClick(object sender)
        {
            Button button = (Button)sender;

            if (textBoxResult.Text.Equals(number1.ToString()) || textBoxResult.Text.Equals(number2.ToString()))
            {
                textBoxResult.Text = "0";
            }

            if (textBoxResult.Text.Equals("0"))
            {
                textBoxResult.Text = button.Text;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + button.Text;
            }
        }

        void saveNumber1()
        {
            number1 = Convert.ToInt32(textBoxResult.Text);
        }

        void keepCounting()
        {
            number2 = Convert.ToInt32(textBoxResult.Text);
            
            if (function.Equals("+"))
            {
                temp = number1 + number2;
                textBoxResult.Text = temp.ToString();
            }
            else if (function.Equals("-"))
            {
                temp = number1 - number2;
                textBoxResult.Text = temp.ToString();
            }
            else if (function.Equals("*"))
            {
                temp = number1 * number2;
                textBoxResult.Text = temp.ToString();
            }
            else if (function.Equals("/"))
            {
                temp = number1 / number2;
                textBoxResult.Text = temp.ToString();
            }
            else if (function.Equals("%"))
            {
                temp = number1 % number2;
                textBoxResult.Text = temp.ToString();
            }
            number1 = temp;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            temp = 0;
            function = "";
            textBoxResult.Text = "0";
        }
    }
}
