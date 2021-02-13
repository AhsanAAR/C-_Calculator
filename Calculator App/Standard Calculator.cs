using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class MyCalculator : Form
    {
        bool screenReset = true;
        bool zero = true;
        char opr = '$';
        bool equal = true;
        double num = 0;
        double temp = 0;
        double memory = 0;
        bool dec = false;

        public MyCalculator()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (screenReset) {
                OutputScreen.Text = "";
                screenReset = false;
                zero = false;
            }
            OutputScreen.Text += One.Text;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (screenReset)
            {
                OutputScreen.Text = "";
                screenReset = false;
                zero = false;
            }
            OutputScreen.Text += Two.Text;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (screenReset)
            {
                OutputScreen.Text = "";
                screenReset = false;
                zero = false;
            }
            OutputScreen.Text += Three.Text;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (screenReset)
            {
                OutputScreen.Text = "";
                screenReset = false;
                zero = false;
            }
            OutputScreen.Text += Four.Text;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (screenReset)
            {
                OutputScreen.Text = "";
                screenReset = false;
                zero = false;
            }
            OutputScreen.Text += Five.Text;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (screenReset)
            {
                OutputScreen.Text = "";
                screenReset = false;
                zero = false;
            }
            OutputScreen.Text += Six.Text;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (screenReset)
            {
                OutputScreen.Text = "";
                screenReset = false;
                zero = false;
            }
            OutputScreen.Text += Seven.Text;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (screenReset)
            {
                OutputScreen.Text = "";
                screenReset = false;
                zero = false;
            }
            OutputScreen.Text += Eight.Text;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (screenReset)
            {
                OutputScreen.Text = "";
                screenReset = false;
                zero = false;
            }
            OutputScreen.Text += Nine.Text;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (zero)
                return;
            if (screenReset)
            {
                OutputScreen.Text = "";
                screenReset = false;
                zero = true;
            }
            OutputScreen.Text += Zero.Text;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            screenReset = zero = equal = true;
            dec = false;
            OutputScreen.Text = "0";
            opr = '$';
            temp = num = 0;
        }

        void calculate()
        {
            switch (opr)
            {
                case '+':
                    temp += num;
                    break;
                case '-':
                    temp -= num;
                    break;
                case '*':
                    temp *= num;
                    break;
                case '/':
                    temp /= num;
                    break;
                default:
                    temp = num;
                    break;
            }
            OutputScreen.Text = temp.ToString();
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (!equal)
                num = double.Parse(OutputScreen.Text);
            else
                temp = double.Parse(OutputScreen.Text);
            calculate();
            screenReset = true;
            dec = false;
            equal = true;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (equal) {
                temp = num = double.Parse(OutputScreen.Text);
            }
            else
            {
                num = double.Parse(OutputScreen.Text);
                calculate();
            }
            opr = '+';
            screenReset = true;
            dec = false;

            equal = false;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                temp = num = double.Parse(OutputScreen.Text);
            }
            else
            {
                num = double.Parse(OutputScreen.Text);
                calculate();
            }
            opr = '-';
            screenReset = true;
            dec = false;
            equal = false;
        }


    
        private void ChangeSign_Click(object sender, EventArgs e)
        {
            double i = double.Parse(OutputScreen.Text);
            i *= -1;
            OutputScreen.Text = i.ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                temp = num = double.Parse(OutputScreen.Text);
            }
            else
            {
                num = double.Parse(OutputScreen.Text);
                calculate();
            }
            opr = '*';
            screenReset = true;
            dec = false;
            equal = false;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                temp = num = double.Parse(OutputScreen.Text);
            }
            else
            {
                num = double.Parse(OutputScreen.Text);
                calculate();
            }
            opr = '/';
            screenReset = true;
            dec = false;
            equal = false;
        }

        private void MemorySave_Click(object sender, EventArgs e)
        {
            memory = double.Parse(OutputScreen.Text);
        }

        private void MemoryPlus_Click(object sender, EventArgs e)
        {
            memory += double.Parse(OutputScreen.Text);
        }

        private void MemoryMinus_Click(object sender, EventArgs e)
        {
            memory += double.Parse(OutputScreen.Text);
        }


        private void MemoryRecall_Click(object sender, EventArgs e)
        {
            OutputScreen.Text = memory.ToString(); 
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (dec)
                return;
            dec = true;
            if (screenReset)
            {
                OutputScreen.Text = "0";
                screenReset = false;
                zero = false;
            }
            OutputScreen.Text += Decimal.Text;
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            temp = double.Parse(OutputScreen.Text);
            temp = Math.Sin(temp);
            OutputScreen.Text = temp.ToString();
            screenReset = true;
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            temp = double.Parse(OutputScreen.Text);
            temp = Math.Cos(temp);
            OutputScreen.Text = temp.ToString();
            screenReset = true;
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            temp = double.Parse(OutputScreen.Text);
            temp = Math.Tan(temp);
            OutputScreen.Text = temp.ToString();
            screenReset = true;
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            OutputScreen.Text = Math.PI.ToString();
            screenReset = true;
        }
    }
}
