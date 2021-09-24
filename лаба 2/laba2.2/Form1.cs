using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2._2
{
    public partial class Form1 : Form
    {
        double interest_rate;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = $"Доход по вкладу: {Convert.ToUInt32(textBox1.Text) * interest_rate}р.";
            }
            catch
            {
                label3.Text = "Данные введены неверно.";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            interest_rate = 0.035;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            interest_rate = 0.055;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            interest_rate = 0.068;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            interest_rate = 0.08;
        }
    }
}
