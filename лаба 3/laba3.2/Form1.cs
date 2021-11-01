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
    public partial class Form1 : Form
    {
        public static List<User> users;
        public static string name;
        public Form1()
        {
            users = new List<User>();
            name = "";
            users.Add(new User("Олеся", "olesya", "123"));
            users.Add(new User("Аида", "aida", "123"));
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (name == "")
            {
                Form2 f = new Form2();
                f.ShowDialog();
                if (name != "")
                    label1.Text = name + ". Выход";
            }
            else
            {
                name = "";
                label1.Text = "Авторизация";
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void рассчётНДФЛToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (name == "")
                MessageBox.Show("Авторизуйтесь");
            else
            {
                Form4 f = new Form4();
                f.ShowDialog();
            }
        }

        private void рассчётСуществованияТреугольникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (name == "")
                MessageBox.Show("Авторизуйтесь");
            else
            {
                Form5 f = new Form5();
                f.ShowDialog();
            }
        }

        private void переводТемпературыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (name == "")
                MessageBox.Show("Авторизуйтесь");
            else
            {
                Form6 f = new Form6();
                f.ShowDialog();
            }
        }

        private void матрица2х2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (name == "")
                MessageBox.Show("Авторизуйтесь");
            else
            {
                Form7 f = new Form7();
                f.ShowDialog();
            }
        }

        private void матрица3х3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (name == "")
                MessageBox.Show("Авторизуйтесь");
            else
            {
                Form8 f = new Form8();
                f.ShowDialog();
            }
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение НДФЛ треугольника и температура матрицы\nВерсия 1.0.0\n(с) Корпорация Зла\nВсе права защищены.\nРазработали студентки группы 4391-22 Еремина Олеся и Сайфутдинова Аида\nЕсть вопросы - спрашивайте :)", "Это справка!!");
        }
    }
}
