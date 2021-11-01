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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void check()
        {
            try
            {
                if (double.Parse(textBox1.Text) + double.Parse(textBox2.Text) > double.Parse(textBox3.Text) &&
                    double.Parse(textBox2.Text) + double.Parse(textBox3.Text) > double.Parse(textBox2.Text) &&
                    double.Parse(textBox3.Text) + double.Parse(textBox1.Text) > double.Parse(textBox2.Text))
                    label4.Text = "Треугольник существует";
                else
                    label4.Text = "Треугольник не существует";
            }
            catch
            {
                label4.Text = "Введите корректные данные";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label6.Text = "Треугольник существует, если сумма длин\nдвух сторон треугольника всегда больше\nдлины третей стороны";
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label6.Text = "";
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это окно проверки треугольников\nДефектные треугольники не пройдут!\n(с) Корпорация Зла\nВсе права защищены.\nРазработали все те же\nЕсть вопросы - спрашивайте :)", "Это справка!!");
        }
    }
}
