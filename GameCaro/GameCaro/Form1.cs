using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
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
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.DrawPanelChessBoard();
            
            NewGame();
        }

        void NewGame()
        {
            UndoButton.Enabled = true;
            undoToolStripMenuItem.Enabled = true;
            ChessBoard.DrawPanelChessBoard();
        }

        void EndGame()
        {
            undoToolStripMenuItem.Enabled = false;
            UndoButton.Enabled = false;
        }

        void Undo()
        {
            ChessBoard.Undo();
        }
        void Quit()
        {
            Application.Exit();
        }
       
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
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
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát!!", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            Undo();
        }
    }
}
