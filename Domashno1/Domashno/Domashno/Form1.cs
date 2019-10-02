using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domashno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is an application that show if the number is odd or even!","ODD/EVEN",
                 MessageBoxButtons.OK,MessageBoxIcon.Information);
            button1.BackColor = Color.Aqua;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int val1 = Int32.Parse(textBox1.Text);
                if (val1 % 2 == 0) {
                    label1.Text = "The number is even !";
                    label1.Font = new Font("Arial", 15);
                    label1.ForeColor = Color.AliceBlue;
                }
                else
                {
                    label1.Text = "The number is odd!";
                    label1.Font = new Font("Arial", 15);
                }
            }
            catch
            {
                MessageBox.Show("Please input correct values","WARNING",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label1.Text = "Please input correct values !!!";
                textBox1.Clear(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
