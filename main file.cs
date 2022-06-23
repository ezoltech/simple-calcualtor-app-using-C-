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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_sign.Text == "+")
            {
                txt_Result.Text = (int.Parse(txt_num1.Text) + int.Parse(txt_num2.Text)).ToString();
            }
            else if(txt_sign.Text == "-")
            {
                txt_Result.Text = (int.Parse(txt_num1.Text) - int.Parse(txt_num2.Text)).ToString();
            }
            else if (txt_sign.Text == "x")
            {
                txt_Result.Text = (int.Parse(txt_num1.Text) * int.Parse(txt_num2.Text)).ToString();
            }
            else if(txt_sign.Text == "/")
            {
                txt_Result.Text = (int.Parse(txt_num1.Text) / int.Parse(txt_num2.Text)).ToString();
            }
            
            else
            {
                MessageBox.Show("Invalid opreator given,please try again!!!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_Result_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

