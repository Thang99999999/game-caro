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
    public partial class Form1 : Form
    {
        #region Properties
        Manager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();
            ChessBoard = new Manager(PanelChessBoard,TextBoxName,PictureBoxPlayer);
            ChessBoard.DrawPanelChessBoard();
            NewGame();
        }

        void NewGame()
        {
            ChessBoard.DrawPanelChessBoard();
        }
        void Undo()
        {

        }
        void Quit()
        {
            Application.Exit();
        }
        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát!!", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
    }
}
