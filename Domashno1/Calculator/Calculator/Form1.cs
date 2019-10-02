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
        public Form1()
        {
            InitializeComponent();
           
        }
        Calc MyCalc = new Calc();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MyCalc.sended = (sender as Button).Text;
                double val1 = Double.Parse(textBox1.Text);
                double val2 = Double.Parse(textBox2.Text);
                textBox3.Text = MyCalc.calculation(val1, val2).ToString();
            }
            catch
            {
                MessageBox.Show(comboBox1.Text);
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MyCalc.sended = (sender as Button).Text;
                double val1 = Double.Parse(textBox1.Text);
                double val2 = Double.Parse(textBox2.Text);
                textBox3.Text = MyCalc.calculation(val1, val2).ToString();

            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MyCalc.sended = (sender as Button).Text;
                double val1 = Double.Parse(textBox1.Text);
                double val2 = Double.Parse(textBox2.Text);
                textBox3.Text = MyCalc.calculation(val1, val2).ToString();

            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MyCalc.sended = (sender as Button).Text;
                double val1 = Double.Parse(textBox1.Text);
                double val2 = Double.Parse(textBox2.Text);
                textBox3.Text = MyCalc.calculation(val1, val2).ToString();
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MyCalc.sended = comboBox1.Text;
                double val1 = Double.Parse(textBox1.Text);
                double val2 = Double.Parse(textBox2.Text);
                textBox3.Text = MyCalc.calculation(val1, val2).ToString();
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }
    }
}
