using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res = 250000;
            if (checkBox1.Checked) res += 9000;
            if (checkBox2.Checked) res += 7000;
            if (checkBox3.Checked) res += 8000;
            label5.Text = res.ToString();
        }
    }
}
