using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Guess
{
    public partial class AboutTheProgram : Form
    {
        public AboutTheProgram()
        {
            InitializeComponent();
        }

        private void AboutTheProgram_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Кузнецов C# Уровень 1. Задание 7.2." + Environment.NewLine +
                                "2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного." + Environment.NewLine +
                                "   a) Для ввода данных от человека используется элемент TextBox;" + Environment.NewLine +
                                "   б) **Реализовать отдельную форму c TextBox для ввода числа." + Environment.NewLine +
                                "" + Environment.NewLine +
                                "Игра создана учеником Кузнецовым В.В.GeekBrains под предводительством Сергея Камянецкого и непосредственным содействие Антоном Алиевым.";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
