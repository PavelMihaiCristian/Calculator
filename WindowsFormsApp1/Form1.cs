using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DNP;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double number1, number2, result;
        private string sign;
        private MathLib mathLib;
        public Form1()
        {
            InitializeComponent();
            number1 = 0;
            number2 = 0;
            sign = string.Empty;
            mathLib = new MathLib();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void performTask(object sender, EventArgs e)
        {
            Button butt = sender as Button;
            if (butt == null)
            {
                return;
            }
            string text = butt.Text;
            switch (text)
            {
                case ".": if (display.Text.Equals(""))
                        {
                            display.AppendText("0");      
                        }
                        display.AppendText(text);
                        break;
                case "0":
                    if (!(display.Text.Equals("")))
                    {
                        display.AppendText("0");
                    }
                    break;
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    if (display.Text.Equals("0"))
                    {
                        display.Clear();
                    }
                    display.AppendText(text);
                    break;
                case "+":
                    /*if (!(sign.Equals("") && display.Text.Equals("")))
                    {
                        number2 = double.Parse(display.Text);
                        number1 = calculateResult(sign);
                    }*/
                    assignSign("+");
                    break;
                case "-":
                    assignSign("-");
                    break;
                case "*":
                    assignSign("*");
                    break;
                case "/":
                    assignSign("/");
                    break;
                case "CE":
                    number2 = 0;
                    display.Clear();
                    break;
                case "C":
                    number1 = 0;
                    number2 = 0;
                    sign = "";
                    display.Clear();
                    break;
                case "<<":
                    if (display.TextLength>1)
                    {
                        display.Text = display.Text.Substring(0, (display.TextLength - 1));
                    }
                    else
                    {
                        display.Text = "0";
                    }
                    break;
                case "-/+":
                    if (!(display.Text.Equals("")))
                    {
                        if (sign.Equals(""))
                        {
                            number1 = double.Parse(display.Text);
                            display.Clear();
                            number1 *= -1;
                            display.Text = number1.ToString();
                        }
                        else
                        {
                            number2 = double.Parse(display.Text);
                            display.Clear();
                            number2 *= -1;
                            display.Text = number2.ToString();
                        }
                    }
                    break;
                case "=":number2= double.Parse(display.Text);
                    display.Clear();
                    result = calculateResult(sign);
                    display.Text =  result.ToString();
                    calculation_Box.Items.Insert(0, number1 + sign + number2 + "=" + result + "\r\n");
                    break;
                case "ClearBLABLABLA": calculation_Box.Items.Clear();
                    break;
                default:break;
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            if (menu == null)
            {
                return;
            }
            string text = menu.Text;
            switch(text)
            {
                case "Save":
                    break;
            }
        }

        private void assignSign(string s)
        {
            number1 = double.Parse(display.Text);
            sign=s;
            display.Clear();
        }


        private double calculateResult(string sign)
        {
            double result=0;
            if (sign.Equals("+"))
            {
                result = mathLib.AddDoubles(number1,number2);
            }
            if (sign.Equals("-"))
            {
                result = mathLib.SubDoubles(number1, number2);
            }
            if (sign.Equals("*"))
            {
                result = mathLib.MultDoubles(number1, number2);
            }
            if (sign.Equals("/"))
            {
                result = mathLib.DivDouble(number1, number2);
            }
            return result;
        }
    }
}
