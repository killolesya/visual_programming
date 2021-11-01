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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private bool login_is_unique(string login)
        {
            for(int i = 0; i < Form1.users.Count; i++)
                if (login == Form1.users[i].Login)
                    return false;
            return true;
        }

        private bool login_is_correct(string login)
        {
            string loginchars = "qwertyuiopasdfghjklzxcvbnm1234567890_";
            for (int i = 0; i < login.Length; i++)
                if (loginchars.Contains(login[i]) == false)
                    return (false);
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Заполните все поля.");
            else if (login_is_correct(textBox2.Text) == false)
                MessageBox.Show("Введен некорректный логин!");
            else if (login_is_unique(textBox2.Text) == false)
                MessageBox.Show("Этот логин уже занят :(\nПопробуйте другой! :)");
            else if (textBox3.Text != textBox4.Text)
                MessageBox.Show("Пароли не совпадают.");
            else
            {
                Form1.users.Add(new User(textBox1.Text, textBox2.Text, textBox3.Text));
                Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.UseSystemPasswordChar == true)
            {
                textBox3.UseSystemPasswordChar = false;
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
                textBox4.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (login_is_correct(textBox2.Text) == false)
                label5.Text = "Логин может содержать только:\nлатинские буквы нижнего регистра;\nцифры;\nнижнее подчёркивание.";
            else if (login_is_unique(textBox2.Text) == false)
                label5.Text = "Этот логин уже занят :(\nПопробуйте другой! :)";
            else
                label5.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox4.Text)
                label6.Text = "Пароли не совпадают.";
            else
                label6.Text = "";
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это окно регистрации\n(с) Корпорация Зла\nВсе права защищены.\nРазработали все те же\nЕсть вопросы - спрашивайте :)", "Это справка!!");
        }
    }
}
