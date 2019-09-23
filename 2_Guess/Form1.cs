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
    public partial class Form1 : Form
    {
        int[] answer = new int[2];
        int unknownNumber = -1;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Блокировка недопустимых клавиш
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void Button1_Click(object sender, EventArgs e) => (new Ответ_пользователя(answer)).Show();
        
        private void Button2_Click(object sender, EventArgs e) =>  unknownNumber = rand.Next(1, 100); 

        private void FPS_Tick(object sender, EventArgs e)
        {
            label4.Text = $"Ход - {answer[1]}";
            if (answer[0] == unknownNumber)
            {
                label1.Visible = false;
                label2.Text = "Вы выиграли!";
                label3.Text = $"Ваш ответ {answer[0]}.";
                button1.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (answer[0] < unknownNumber)
            {
                label1.Visible = true;
                label2.Text = "Ваш ответ меньше загаданного числа.";
                label3.Text = $"Ваш ответ {answer[0]}.";

                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (answer[0] > unknownNumber)
            {
                label1.Visible = true;
                label2.Text = "Ваш ответ больше загаданного числа.";
                label3.Text = $"Ваш ответ {answer[0]}.";

                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
            }
            if(answer[0] == -1)
            {
                label1.Visible = true;
                label2.Text = "";
                label3.Text = "";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            unknownNumber = rand.Next(1, 100);
            answer[0] = -1;
            label3.Text = "";
        }

        private void НоваяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            unknownNumber = rand.Next(1, 100);
            answer[0] = -1;
            answer[1] = 0;
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutTheProgram()).Show();
        }
    }
}
