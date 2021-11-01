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

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это окно вывыода стихотворения\nВ детстве одна из нас любила Пастернака, поэтому вот\n(с) Корпорация Зла\nВсе права защищены.\nРазработали все те же\nЕсть вопросы - спрашивайте :)", "Это справка!!");
        }
    }
}
