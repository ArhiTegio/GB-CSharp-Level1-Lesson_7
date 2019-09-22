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
    public partial class Ответ_пользователя : Form
    {
        int[] number;

        public Ответ_пользователя(int[] number2)
        {
            this.number = number2;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                number[0] = int.Parse(textBox1.Text);
                number[1]++;
                this.Close();
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Блокировка недопустимых клавиш
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }
    }
}
