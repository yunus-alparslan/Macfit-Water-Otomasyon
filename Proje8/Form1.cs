using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == label1.Text)
            {
                pictureBox1.Visible = false;
                label1.Visible = false;
            }
            else if (textBox1.Text == label2.Text)
            {
                pictureBox2.Visible = false;
                label2.Visible = false;
            }
            else if (textBox1.Text == label3.Text)
            {
                pictureBox3.Visible = false;
                label3.Visible = false;
            }

            else if (textBox1.Text == label4.Text)
            {
                pictureBox4.Visible = false;
                label4.Visible = false;
            }
            else if (textBox1.Text == label5.Text)
            {
                pictureBox5.Visible = false;
                label5.Visible = false;
            }
            else if (textBox1.Text == label6.Text)
            {
                pictureBox6.Visible = false;
                label6.Visible = false;
            }
            else if (textBox1.Text == label7.Text)
            {
                pictureBox7.Visible = false;
                label7.Visible = false;
            }
            else if (textBox1.Text == label8.Text)
            {
                pictureBox8.Visible = false;
                label8.Visible = false;
            }
            else if (textBox1.Text == label9.Text)
            {
                pictureBox9.Visible = false;
                label9.Visible = false;
            }
            else if (textBox1.Text == label10.Text)
            {
                pictureBox10.Visible = false;
                label10.Visible = false;
            }
            else if (textBox1.Text == label11.Text)
            {
                pictureBox11.Visible = false;
                label11.Visible = false;
            }
            else if (textBox1.Text == "0" )
            {
                MessageBox.Show("Error");
                button1.Visible = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
