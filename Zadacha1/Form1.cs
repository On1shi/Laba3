using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a + b;
            label3.Text = Convert.ToString(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a - b;
            label3.Text = Convert.ToString(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a * b;
            label3.Text = Convert.ToString(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a / b;
            label3.Text = Convert.ToString(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Lime;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Cyan;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Pink;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
            label3.Text = "0";
        }
    }
}
