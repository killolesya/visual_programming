using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2._1
{
    public partial class Form1 : Form
    {
        int price;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(textBox1.Text);
                if (count < 0)
                {
                    label2.Text = "Данные введены неверно.";
                    label3.Text = "";
                    label4.Text = "";
                }
                else
                {
                    label2.Text = $"Цена: {price}.00р.";
                    label3.Text = $"Количество: {count}шт.";
                    label4.Text = $"Сумма: {price * count}.00р.";
                }
            }
            catch
            {
                label2.Text = "Данные введены неверно.";
                label3.Text = "";
                label4.Text = "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 5;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 7;
        }
    }
}
