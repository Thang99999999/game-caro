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
         
            rtbRule.Text = "                                     LUẬT CHƠI BÀN CỜ \n\n ";

            rtbRule.Text += "Game Caro 2 người chơi, lượt chơi 2 người sẽ luôn phiên nhau.\n" +
                            "Một người đi X, một người đi O. Khi đến lượt, người chơi phải\n" +
                            "tích chọn vào một ô trên bàn cờ. Người chơi cần tìm cách tích\n" +
                            "đủ 5 ô theo chiều dọc, chiều ngang hoặc đường chéo mà không\n" +
                            " bị đối thủ chặn 2 đầu thì sẽ thắng.\n\n";
            
            rtbRule.Text += "* Đối với bàn cờ 3x3 thì người nào đi đủ 3 quân cờ \n" +
                " trước sẻ là người chiến thắng \n";
            rtbRule.Text += "* Đối với bàn cờ 5x5 thì người nào đi đủ 4 quân cờ \n" +
                "trước sẻ là người chiến thắng \n";
            rtbRule.Text += "* Đối với bàn cờ 6x6 trở đi thì người chiến thắng sẽ" +
                "\n là người đi đủ 5 quân cờ trước \n";
            rtbRule.Text += "\n*Đặc biệt, khi bạn đi nhầm nút bạn có thể nhấn vào" +
                "\n Undo để đi lại nước vừa đánh \n\n";
            rtbRule.Text += "                         **************** END ***************\n\n";
            rtbRule.Text += "       ^.^ ********* Chúc các bạn chơi game vui vẻ ********* ^.^";
        }
    }
}
