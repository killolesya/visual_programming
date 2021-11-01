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

        private int Ft_convert(int num, int res)
        {
            if (num > 0)
            {
                res = Ft_convert(num / 2, res);
                res = res * 10 + num % 2;
            }
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int res = 0;
            res = Ft_convert(num, res);
            textBox2.Text = res.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это окно для перевода чисел из десятичной системы счисления в двоичную\n(с) Корпорация Зла\nВсе права защищены.\nРазработали все те же\nЕсть вопросы - спрашивайте :)", "Это справка!!");
        }
    }
}
