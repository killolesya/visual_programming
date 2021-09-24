using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1._2
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
