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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = ((double.Parse(textBox1.Text) * 1.8) + 32).ToString();
            }
            catch
            {
                MessageBox.Show("Неверрно введены данные");
            }
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = "Т (° F) = Т (° C) × 9/5 + 32";
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это окно перевода температуры\nНа данный момент работаем над переводом октябрьской температуры в июльскую. Ждите.\n(с) Корпорация Зла\nВсе права защищены.\nРазработали все те же\nЕсть вопросы - спрашивайте :)", "Это справка!!");
        }
    }
}
