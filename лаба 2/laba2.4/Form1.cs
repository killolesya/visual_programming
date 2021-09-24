using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double n = double.Parse(textBox1.Text);
                double m = double.Parse(textBox2.Text);

                if (n < 0 || m < 0)
                    label4.Text = "Ведены неверные данные.";
                else
                    label4.Text = $"Результат: {n * m / 100 * 47}р.";
            }
            catch
            {
                label4.Text = "Ведены неверные данные.";
            }
        }
    }
}
