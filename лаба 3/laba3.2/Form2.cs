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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool f = true;
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Неправильный логин или пароль!");
            else
            {
                for (int i = 0; i < Form1.users.Count; i++)
                    if (textBox1.Text == Form1.users[i].Login)
                        if (textBox2.Text == Form1.users[i].Password)
                        {
                            Form1.name = Form1.users[i].Name;
                            f = false;
                            Close();
                        }
                if (f)
                    MessageBox.Show("Неправильный логин или пароль!");
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это окно авторизации\n(с) Корпорация Зла\nВсе права защищены.\nРазработали все те же\nЕсть вопросы - спрашивайте :)", "Это справка!!");
        }
    }
}
