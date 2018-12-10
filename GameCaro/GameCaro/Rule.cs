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
            
            rtbRule.Text += "* Đối với bàn cờ 3x3 thì người nào đi đủ 3 quân cờ trên 1 đường\n" +
                "thẳng trước sẻ là người chiến thắng \n";
            rtbRule.Text += "* Đối với bàn cờ 5x5 thì người nào đi đủ 5 quân cờ trên 1 đường\n" +
                "thẳng trước sẻ là người chiến thắng \n";
            rtbRule.Text += "* Đối với những bàn cờ lớn hơn kích thước 7x7 thì ta áp dụng\n" +
                "thêm luật dù đủ 5 quân cờ trên 1 đường thẳng mà bị chặn 2 đầu\n" +
                "vẫn chưa tính là thắng cuộc\n";
            rtbRule.Text += "* Đối với bàn cờ lớn hơn 7x7 thì có lớn hơn 5 quân cờ trên 1 \n" +
                "đường thẳng dù không bị chặn 2 đầu vẫn không tính là chiến  \n " +
                "thắng  \n";
            rtbRule.Text += "* Khi bạn đi nhầm nút bạn có thể nhấn vào undo để đi lại nước \n" +
                " vừa đánh \n\n";
            rtbRule.Text += "                         **************** END ***************\n\n";
            rtbRule.Text += "       ^.^ ********* Chúc các bạn chơi game vui vẻ ********* ^.^";
        }
    }
}
