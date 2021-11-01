using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3._2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это окно решения квадратных уравнений\nтреугольные не решаем\n(с) Корпорация Зла\nВсе права защищены.\nРазработали все те же\nЕсть вопросы - спрашивайте :)", "Это справка!!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                double a, b, c, d;
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                d = b * b - 4 * a * c;
                if (d < 0)
                    label5.Text = "Действительных корней нет";
                else if (d == 0)
                    label5.Text = $"x = {-b / (2 * a)}";
                else
                    label5.Text = $"x1 = {(-b-Math.Sqrt(d))/ (2*a)}\n x2 = {(-b+Math.Sqrt(d))/ (2*a)}";
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }
    }
}
