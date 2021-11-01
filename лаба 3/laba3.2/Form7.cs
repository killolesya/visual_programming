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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = ((double.Parse(textBox1.Text) * double.Parse(textBox4.Text)) - (double.Parse(textBox2.Text) * double.Parse(textBox3.Text))).ToString();
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
            MessageBox.Show("Это окно рассчёта матрицы 2х2\nшуток не осталось, простите\n(с) Корпорация Зла\nВсе права защищены.\nРазработали все те же\nЕсть вопросы - спрашивайте :)", "Это справка!!");
        }
    }
}
