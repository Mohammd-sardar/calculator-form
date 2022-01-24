using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBox1.Text)+ double.Parse(textBox2.Text);
          //  MessageBox.Show(result.ToString());
            label3.Text = result.ToString(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
          
            label3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
         
            label3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
      
            label3.Text = result.ToString();
        }
    }
}
