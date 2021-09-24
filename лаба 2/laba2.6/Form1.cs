using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2._6
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> digits = new Dictionary<int, string>();
        public Form1()
        {
            InitializeComponent();
            digits.Add(0, "ноль ");
            digits.Add(1, "один ");
            digits.Add(2, "два ");
            digits.Add(3, "три ");
            digits.Add(4, "четыре ");
            digits.Add(5, "пять ");
            digits.Add(6, "шесть ");
            digits.Add(7, "семь ");
            digits.Add(8, "восемь ");
            digits.Add(9, "девять ");
            digits.Add(10, "десять ");
            digits.Add(11, "одиннадцать ");
            digits.Add(12, "двенадцать ");
            digits.Add(13, "тринадцать ");
            digits.Add(14, "четырнадцать ");
            digits.Add(15, "пятнадцать ");
            digits.Add(16, "шестнадцать ");
            digits.Add(17, "семнадцать ");
            digits.Add(18, "восемнадцать ");
            digits.Add(19, "девятнадцать ");
            digits.Add(20, "двадцать ");
            digits.Add(30, "тридцать ");
            digits.Add(40, "сорок ");
            digits.Add(50, "пятьдесят ");
            digits.Add(60, "шестьдесят ");
            digits.Add(70, "семьдесят ");
            digits.Add(80, "восемьдесят ");
            digits.Add(90, "девяносто ");
            digits.Add(100, "сто ");
            digits.Add(200, "двести ");
            digits.Add(300, "триста ");
            digits.Add(400, "четыреста ");
            digits.Add(500, "пятьсот ");
            digits.Add(600, "шестьсот ");
            digits.Add(700, "семьсот ");
            digits.Add(800, "восемьсот ");
            digits.Add(900, "девятьсот ");
            digits.Add(1000, "тысяч");
            digits.Add(1000000, "миллион");
            digits.Add(1000000000, "миллиард");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                if (num < 0)
                {
                    label2.Text = "Неверно введены данные.";
                    return;
                }
                List<int> hundreds = new List<int>();
                string res = "";
                string f;
                if (num == 0)
                    label2.Text = digits[0];
                else
                {
                    while (num > 0)
                    {
                        hundreds.Add(num % 1000);
                        num /= 1000;
                    }
                    while (hundreds.Count > 0)
                    {
                        int temp;
                        f = "";
                        temp = hundreds.Last() / 100;
                        if (temp > 0)
                            res += digits[temp * 100];
                        temp = hundreds.Last() % 100;
                        if (temp < 20 && temp > 9)
                            res += digits[temp];
                        else
                        {
                            if (temp > 19)
                                res += digits[temp - temp % 10];
                            temp %= 10;
                            if (temp != 0)
                            {
                                if (temp == 1 && hundreds.Count == 2)
                                {
                                    res += "одна ";
                                    f = "a";
                                }
                                else if (temp == 2 && hundreds.Count == 2)
                                    res += "две ";
                                else
                                    res += digits[temp];
                                if (temp > 1 && temp < 5 && hundreds.Count == 2)
                                    f = "и";
                                if (temp > 1 && temp < 5 && hundreds.Count > 2)
                                    f = "a";
                                if (temp > 4 && hundreds.Count > 2)
                                    f = "ов";
                            }
                        }
                        if (hundreds.Count == 2)
                            temp = 1000;
                        if (hundreds.Count == 3)
                            temp = 1000000;
                        if (hundreds.Count == 4)
                            temp = 1000000000;
                        if (hundreds.Last() != 0 && hundreds.Count > 1)
                        {
                            res += digits[temp];
                            res += f;
                            res += " ";
                        }
                        hundreds.RemoveAt(hundreds.Count - 1);
                    }
                    label2.Text = res;
                }
            }
            catch
            {
                label2.Text = "Неверно введены данные.";
            }
        }
    }
}
