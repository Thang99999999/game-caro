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
    public partial class Size : Form
    {

        static public int ChessWidth = 0;

        static public int ChessHeight = 0;

        static public int ChessBoardWidth = 0;

        static public int ChessBoardHeight = 0;

        static public int LineWin = 0;

        public Size()
        { 

            InitializeComponent();
            panelSwap.Hide();
        }

        public string SizeBoard()
        {
            return ChessBoardHeight.ToString() + "x" + ChessBoardWidth.ToString();
        }

        public void LineToWin()
        {
            LineWin = (ChessBoardHeight >= ChessBoardWidth) ? ChessBoardWidth : ChessBoardHeight;

            if (LineWin > 5)
                LineWin = 5;
            else
            {
                if (LineWin < 5)
                    LineWin = 3;
                else LineWin = 4;
            }
        }

        private void OKSizeButton_Click(object sender, EventArgs e)
        {
            int Row = (int)Numrow.Value;
            int Col = (int)NumCol.Value;

            ChessBoardHeight = Row;
            ChessBoardWidth = Col;

            int Max;
            Max = (Row >= Col) ? Row : Col;

            ChessHeight = 540 / Max;
            ChessWidth = 540 / Max;

            LineToWin();

            ChangeForm();
        }

        public void ChangeForm()
        {
            if (MessageBox.Show(("Tạo bàn cờ với kích thước " + ChessBoardHeight.ToString()
                 + "x" + ChessBoardWidth.ToString()), "Thông báo!!",
                 MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                OKSizeButton.Enabled = false;
                Form b = new Form1();
                this.Hide();
                b.ShowDialog();
                Application.Exit();
            }
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            ChessBoardHeight = 3;
            ChessBoardWidth = 3;

            ChessHeight = 180;
            ChessWidth = 180;

            LineToWin();

            ChangeForm();
        }

        private void Button55_Click(object sender, EventArgs e)
        {
            ChessBoardHeight = 5;
            ChessBoardWidth = 5;

            ChessHeight = 110;
            ChessWidth = 110;

            LineToWin();

            ChangeForm();
        }

        private void Button77_Click(object sender, EventArgs e)
        {
            ChessBoardHeight = 7;
            ChessBoardWidth = 7;

            ChessHeight = 80;
            ChessWidth = 80;

            LineToWin();

            ChangeForm();
        }

        private void OtherSizeButton_Click(object sender, EventArgs e)
        {
            panelSwap.Show();
        }

        private void Size_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(OKSizeButton.Enabled==false)
            {
                e.Cancel = false;
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn thoát!!", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
    
}
