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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }
    }
}
