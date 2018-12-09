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

            RButton3.Enabled = false;
            RButton5.Enabled = false;
            RButton9.Enabled = false;

            Numrow.Enabled = false;
            NumCol.Enabled = false;

            OKSizeButton.Enabled = false;
        }

        public string SizeBoard()
        {
            return ChessBoardHeight.ToString() + "x" + ChessBoardWidth.ToString();
        }

        public void SetupCheck()
        {
            if (RBStandart.Checked)
            {
                if (RButton3.Checked == true)
                {

                    ChessBoardHeight = 3;
                    ChessBoardWidth = 3;

                    ChessHeight = 180;
                    ChessWidth = 180;
                }
                else if (RButton5.Checked == true)
                { 
                    ChessBoardHeight = 5;
                    ChessBoardWidth = 5;

                    ChessHeight = 110;
                    ChessWidth = 110;
                }
                else if (RButton9.Checked == true)
                {
                    ChessBoardHeight = 9;
                    ChessBoardWidth = 9;

                    ChessHeight = 60;
                    ChessWidth = 60;
                }
                else { OKSizeButton.Enabled = false; }
            }
            else if(RBOption.Checked)
            {
                int Row = (int)Numrow.Value;
                int Col = (int)NumCol.Value;

                ChessBoardHeight = Row;
                ChessBoardWidth = Col;

                int Max;
                Max = (Row >= Col) ? Row : Col;

                ChessHeight = 540/Max;
                ChessWidth = 540/Max;
            }

            LineWin = (ChessBoardHeight >= ChessBoardWidth)
                ? ChessBoardWidth :ChessBoardHeight;

            if (LineWin < 5)
                LineWin = 3;
            else if (LineWin > 5)
                LineWin = 5;
            else LineWin = 4;
        }
        private void OKSizeButton_Click(object sender, EventArgs e)
        {
            SetupCheck();

            if (MessageBox.Show(("Tạo bàn cờ với kích thước " + ChessBoardHeight.ToString()
                 + "x" + ChessBoardWidth.ToString()), "Thông báo!!",
                 MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Form b = new Form1();
                this.Hide();
                b.ShowDialog();
                this.Show();
                Application.Exit();

            }
            else
            {
                this.Hide();
                Form b = new Size();
                b.ShowDialog();
            }

        }
        private void RBOption_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            OKSizeButton.Enabled = false;

            if(RBStandart.Checked)
            {
                RButton3.Enabled = true;
                RButton5.Enabled = true;
                RButton9.Enabled = true;
            }
            else
            {
                RButton3.Enabled = false;
                RButton5.Enabled = false;
                RButton9.Enabled = false;
            }
            if(RBOption.Checked)
            {
                Numrow.Enabled = true;
                NumCol.Enabled = true;
                OKSizeButton.Enabled = true;
            }
            else
            {
                Numrow.Enabled = false;
                NumCol.Enabled = false;
            }
        }

        private void RButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(RButton3.Checked || RButton5.Checked || RButton9.Checked)
            {
                OKSizeButton.Enabled = true;
            }
        }
    }
    
}
