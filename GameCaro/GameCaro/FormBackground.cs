using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Form a = new Size();
            this.Hide();
            a.ShowDialog();
            Application.Exit();
        }

        private void Background_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (button1.Enabled == false)
                e.Cancel = false;
        }
    }
}
