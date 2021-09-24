using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox3.Text = (a + b).ToString();
                    break;
                case 1:
                    textBox3.Text = (a - b).ToString();
                    break;
                case 2:
                    textBox3.Text = (a * b).ToString();
                    break;
                case 3:
                    textBox3.Text = (a / b).ToString();
                    break;
                default:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
