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
    public partial class Form1 : Form
    {
        bool Think = false;

        Game game = new Game();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            goal.Text = "";
            position.Text = "";
            step.Text = "";
            label2.Visible = pictureBox4.Visible = false;
            button1.Enabled = button2.Enabled = button3.Enabled = false;
            pictureBox1.Image = Properties.Resources.idea__1_;
            pictureBox3.Image = Properties.Resources.idea;
            pictureBox1.Visible = false;
        }

        private void CheckPos()
        {
            if(game.Goal < game.Position)
            {
                label2.Visible = pictureBox4.Visible = true;
                pictureBox2.Visible = false;
            }
            else if (game.Goal == game.Position)
            {
                button1.Enabled = button2.Enabled = button3.Enabled = false;
                Think = !Think;
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                FPS.Stop();
                (new Victory(game.Step)).Show();
            }
            else
            {
                label2.Visible = pictureBox4.Visible = false;
                pictureBox2.Visible = true;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FPS_Tick(object sender, EventArgs e)
        {
            if (Think)
            {
                Think = !Think;
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
            }
            else
            {
                Think = !Think;
                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
            }
        }

        private void НоваяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new Game();
            FPS.Start();
            button1.Enabled = button2.Enabled = button3.Enabled = true;
            goal.Text = game.Goal.ToString();
            position.Text = game.Position.ToString();
            step.Text = game.Step.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            game.Multiplier();
            position.Text = game.Position.ToString();
            step.Text = game.Step.ToString();
            CheckPos();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            game.Addition();
            position.Text = game.Position.ToString();
            step.Text = game.Step.ToString();
            CheckPos();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            game.StepBack();
            position.Text = game.Position.ToString();
            step.Text = game.Step.ToString();
            CheckPos();
        }

        private void МенюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutTheProgram()).Show();
        }
    }
}
