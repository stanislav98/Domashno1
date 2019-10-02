using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FormApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Add(double val1,double val2) {
            return val1 + val2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tHello \t\n\t world and idiots !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Blue;
            this.BackColor = Color.Navy;
            label1.Text = "Nice one , you clicked on BLUE BUTTON";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            this.BackColor = Color.PaleVioletRed;
            label1.Text = "Nice one , you clicked on RED BUTTON";
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            this.BackColor = Color.Black;
            label1.Text = "Click one of the buttons bellow \n to see the magic working...";
            label1.Font = new Font("Arial", 14);
            label1.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
                double val1, val2; //Декларираме 2 променливи от тип double type
                try
                {   //Ще присвоим на първата променлива стойността в първото текстово поле
                    //Тъй като това е string, трябва да конвертираме към double
                    val1 = Double.Parse(textBox1.Text);
                    val2 = Double.Parse(textBox2.Text);
                //Обратно конвертираме
                //от double към string, използвайки .ToString() 
                // textBox3.Text = val1.ToString() + " + " + val2.ToString() + " = " +(val1 + val2).ToString();
                textBox3.Text = Add(val1, val2).ToString();
                }
                catch
                {
                    MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                }

            }
        }
}
