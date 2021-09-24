using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2._3
{
    public partial class Form1 : Form
    {
        double c;
        bool f;
        public Form1()
        {
            InitializeComponent();
            f = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            c = 1.3;
            f = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            c = 1.4;
            f = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            c = 1.35;
            f = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double n;
                double prob;
                double k;
                uint year = Convert.ToUInt32(textBox1.Text);
                if (year < 1990 || year > 2021)
                {
                    label4.Text = "Введены неверные данные.";
                    return;
                }
                if (year < 2000)
                    n = 1.5;
                else if (year < 2010)
                    n = 1.3;
                else if (year < 2020)
                    n = 1.2;
                else
                    n = 1.15;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        prob = 1.145;
                        break;
                    case 1:
                        prob = 1.25;
                        break;
                    case 2:
                        prob = 1.337;
                        break;
                    case 3:
                        prob = 1.4;
                        break;
                    case 4:
                        prob = 1.45;
                        break;
                    default:
                        label4.Text = "Введены неверные данные.";
                        return;
                        break;
                }
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        k = 1.45;
                        break;
                    case 1:
                        k = 1.4;
                        break;
                    case 2:
                        k = 1.337;
                        break;
                    case 3:
                        k = 1.25;
                        break;
                    case 4:
                        k = 1.145;
                        break;
                    default:
                        label4.Text = "Введены неверные данные.";
                        return;
                        break;
                }
                if (f)
                    label4.Text = "Введены неверные данные.";
                else
                label4.Text = $"Результат: {2000 + 6000 * n * k * prob}";
            }
            catch
            {
                label4.Text = "Введены неверные данные.";
            }
        }
    }
}
