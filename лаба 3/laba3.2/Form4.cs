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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = (double.Parse(textBox1.Text) * 0.87).ToString() +"р.";
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = "Рассчёт НДФЛ подразумевает вычет из заработной платы 13%";
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = "";
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это окно рассчета НДФЛ\nпудинг торт\n(с) Корпорация Зла\nВсе права защищены.\nРазработали все те же\nЕсть вопросы - спрашивайте :)", "Это справка!!");
        }
    }
}
