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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = (double.Parse(textBox1.Text) * double.Parse(textBox5.Text) * double.Parse(textBox9.Text)
                    + double.Parse(textBox2.Text) * double.Parse(textBox6.Text) * double.Parse(textBox7.Text)
                    + double.Parse(textBox3.Text) * double.Parse(textBox4.Text) * double.Parse(textBox8.Text)
                    - double.Parse(textBox3.Text) * double.Parse(textBox5.Text) * double.Parse(textBox7.Text)
                    - double.Parse(textBox2.Text) * double.Parse(textBox4.Text) * double.Parse(textBox9.Text)
                    - double.Parse(textBox1.Text) * double.Parse(textBox6.Text) * double.Parse(textBox8.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "Определитель равен сумме произведений элементов\nкакой-нибудь строки или столбца\nна их алгебраические дополнения";
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это окно рассчёта матрицы 3х3\nтакое же как 2х2 только 3х3\n(с) Корпорация Зла\nВсе права защищены.\nРазработали все те же\nЕсть вопросы - спрашивайте :)", "Это справка!!");
        }
    }
}
