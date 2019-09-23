using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_GameDoubler
{
    public partial class AboutTheProgram : Form
    {
        public AboutTheProgram()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AboutTheProgram_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Кузнецов C# Уровень 1. Задание 7.1." + Environment.NewLine +
                                "1.а) Добавить в программу «Удвоитель» подсчет количества отданных команд." + Environment.NewLine +
                                "  б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен постараться получить это число за минимальное количество ходов." + Environment.NewLine +
                                "  в) *Добавить кнопку «Отменить», которая отменяет последние ходы." + Environment.NewLine +
                                "" + Environment.NewLine +
                                "Игра создана учеником Кузнецовым В.В.GeekBrains под предводительством Сергея Камянецкого и непосредственным содействие Антоном Алиевым.";
        }
    }
}
