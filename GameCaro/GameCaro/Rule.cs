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
    public partial class Rule : Form
    {
        public Rule()
        {
            InitializeComponent();
        }

        private void IgnoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rtbRule_TextChanged(object sender, EventArgs e)
        {
            Size s = new Size();
            rtbRule.Text = "    LUẬT CHƠI BÀN CỜ " + s.SizeBoard() + "\n";
            rtbRule.Text += "\nHai người chơi luân phiên đánh dấu \n" + "Người thắng cuộc là người đi đủ "
                + "nước, tính theo dòng, cột hay đường chéo mà không bị đối thủ chặn sát 2 đầu!";
        }
    }
}
