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
    public partial class Victory : Form
    {
        int step = 0;
        public Victory(int step)
        {
            this.step = step;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) => this.Close();

        private void Victory_Load(object sender, EventArgs e)
        {
            //label1.Text = $"Злой компьютер повержен Вами за {step} шагов!";
        }
    }
}
