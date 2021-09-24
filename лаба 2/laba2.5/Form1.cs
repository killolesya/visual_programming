using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2._5
{
    public partial class Form1 : Form
    {
        List<int> appraisals = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        public bool result(int g)
        {
            if (g > 100 || g < 0)
                return false;
            return true;
        }

        public void transfer_of_points(List<int> points)
        {
            for (int i=0; i < points.Count; i++)
            {
                if (points[i] < 61) appraisals.Add(2);
                else if (points[i] < 74) appraisals.Add(3);
                else if (points[i] < 87) appraisals.Add(4);
                else appraisals.Add(5);
            }
        }

        public int definition_of_scholarship()
        {
            if (appraisals.Contains(2) || appraisals.Contains(3))
                return 0;
            else if (!appraisals.Contains(4))
                return 5490;
            else if (appraisals.FindAll(
                delegate (int p)
                {
                    return p == 4;
                }).Count > 1)
                return 1830;
            else return 3660;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                appraisals.Clear();
                List<int> points = new List<int>();
                points.Add(int.Parse(textBox1.Text));
                points.Add(int.Parse(textBox2.Text));
                points.Add(int.Parse(textBox3.Text));
                points.Add(int.Parse(textBox4.Text));

                if (!result(points[0]) || !result(points[1]) || !result(points[2]) || !result(points[3]))
                    label6.Text = "Введены неверные данные.";
                else
                {
                    transfer_of_points(points);
                    label6.Text = $"Ваша стипендия: {definition_of_scholarship()}руб.";
                }
            }
            catch
            {
                label6.Text = "Введены неверные данные.";
            }
        }
    }
}
