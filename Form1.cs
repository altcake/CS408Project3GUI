using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS408Project3GUI
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string operation = "";
        bool op = false;
        bool DecimalUsed = false;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }
        private void textBox1_KeyPress(object sender, KeyEventArgs e)
        {
            try
            {
                Double value1 = 0;
                Double value2 = 0;
                Double result = 0;
                if (e.KeyCode == Keys.Enter)
                {
                    string currString = textBox1.Text;
                    if (currString.IndexOf("/") >= 0)
                    {
                        int index = currString.IndexOf("/");
                        value1 = Double.Parse(textBox1.Text.Substring(0, index));
                        value2 = Double.Parse(textBox1.Text.Substring(index + 1));
                        result = value1 / value2;
                        textBox1.Text = result.ToString();
                        textBox1.Select(textBox1.Text.Length, 0);
                    }
                    else if (currString.IndexOf("*") >= 0)
                    {
                        int index = currString.IndexOf("*");
                        value1 = Double.Parse(textBox1.Text.Substring(0, index));
                        value2 = Double.Parse(textBox1.Text.Substring(index + 1));
                        result = value1 * value2;
                        textBox1.Text = result.ToString();
                        textBox1.Select(textBox1.Text.Length, 0);
                    }
                    else if (currString.IndexOf("+") >= 0)
                    {
                        int index = currString.IndexOf("+");
                        value1 = Double.Parse(textBox1.Text.Substring(0, index));
                        value2 = Double.Parse(textBox1.Text.Substring(index + 1));
                        result = value1 + value2;
                        textBox1.Text = result.ToString();
                        textBox1.Select(textBox1.Text.Length, 0);
                    }
                    else if (currString.IndexOf("-") >= 0)
                    {
                        int index = currString.IndexOf("-");
                        value1 = Double.Parse(textBox1.Text.Substring(0, index));
                        value2 = Double.Parse(textBox1.Text.Substring(index + 1));
                        result = value1 - value2;
                        textBox1.Text = result.ToString();
                        textBox1.Select(textBox1.Text.Length, 0);
                    }
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Input was in an unexpected format.", "You messed up");
                textBox1.ClearUndo();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += 5;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += 7;
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            //add code here
            switch (operation)
            {
                case "/":
                    string currString = textBox1.Text;
                    int index = currString.IndexOf("/");
                    value = value / Double.Parse(textBox1.Text.Substring(index+1));
                    textBox1.Text = value.ToString();
                    break;
                case "*":
                    currString = textBox1.Text;
                    index = currString.IndexOf("*");
                    value = value * Double.Parse(textBox1.Text.Substring(index+1));
                    textBox1.Text = value.ToString();
                    break;
                case "+":
                    currString = textBox1.Text;
                    index = currString.IndexOf("+");
                    value = value + Double.Parse(textBox1.Text.Substring(index+1));
                    textBox1.Text = value.ToString();
                    break;
                case "-":
                    currString = textBox1.Text;
                    index = currString.IndexOf("-");
                    value = value - Double.Parse(textBox1.Text.Substring(index+1));
                    textBox1.Text = value.ToString();
                    break;
                default:
                    //default do nothing
                    break;
            }
            //operation done, clear var
            operation = "";
            op = false;
            DecimalUsed = false;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {       
                //add code here
                operation = "/";
                //save current value in textbox then clear textbox
                try
                {
                    value = Double.Parse(textBox1.Text);
                    textBox1.Text += "/";
                    op = true;
                    DecimalUsed = false;
                }
                catch (System.FormatException ex)
                {
                    MessageBox.Show("Input was in an unexpected format.", "You messed up");
                    textBox1.ClearUndo();
                }
                
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
                //add code here
                operation = "*";
                //save current value in textbox then clear textbox
                try
                {
                    value = Double.Parse(textBox1.Text);
                    textBox1.Text += "*";
                    op = true;
                    DecimalUsed = false;
                }
                catch (System.FormatException ex)
                {
                    MessageBox.Show("Input was in an unexpected format.", "You messed up");
                    textBox1.ClearUndo();
                }
                
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
                //add code here
                operation = "+";
                //save current value in textbox then clear textbox
                try
                {
                    value = Double.Parse(textBox1.Text);
                    textBox1.Text += "+";
                    op = true;
                    DecimalUsed = false;
                }
                catch (System.FormatException ex)
                {
                    MessageBox.Show("Input was in an unexpected format.", "You messed up");
                    textBox1.ClearUndo();
                }
                
        }       

        private void SubtractionButton_Click(object sender, EventArgs e)
        {

                //add code here
                operation = "-";
                //save current value in textbox then clear textbox
                try
                {
                    value = Double.Parse(textBox1.Text);
                    textBox1.Text += "-";
                    op = true;
                    DecimalUsed = false;
                }
                catch (System.FormatException ex)
                {
                    MessageBox.Show("Input was in an unexpected format.", "You messed up");
                    textBox1.ClearUndo();
                }
                
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (!DecimalUsed)
            {
                textBox1.Text += ".";
                DecimalUsed = true;
            }
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            String currentString = textBox1.Text;
            //if current value already has a '-' appended to the front, then remove it
            if (currentString[0] == '-') {
                textBox1.Text = currentString.Substring(1, currentString.Length-1);
            }
            //append '-' to front of current value
            else textBox1.Text = "-" + textBox1.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += 9;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += 8;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += 6;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += 4;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += 3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += 1;
            }
        }
    }
}
