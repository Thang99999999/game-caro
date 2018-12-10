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
            ChessBoard.SizePanel();
            ChessBoard.LocationPanel();
            ChessBoard.DrawPanelChessBoard();

            NewGame();

            ToolTip tip = new ToolTip();
            tip.SetToolTip(NewGameButton, "Ctrl+A");
            tip.SetToolTip(QuitButton, "Ctrl+Q");
            tip.SetToolTip(UndoButton, "Ctrl+U");
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
            if (undoToolStripMenuItem.Enabled == false || (MessageBox.Show("Bạn có muốn tạo bàn cờ mới?", "Thông báo!", 
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)  )
            { 
               NewGame();
            }
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
            if (sizeBoardToolStripMenuItem.Enabled == false)
            {
                e.Cancel = false;
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn thoát!!", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void Rule_Click(object sender, EventArgs e)
        {
            Form b = new Rule();
            b.ShowDialog();
            this.Show();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            if (undoToolStripMenuItem.Enabled == false || (MessageBox.Show("Bạn có muốn tạo bàn cờ mới?", "Thông báo!",
              MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK))
            {
                NewGame();
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void sizeBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát bàn cờ hiện tại!", "Thông báo", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                sizeBoardToolStripMenuItem.Enabled = false;
                Form c = new Size();
                this.Hide();
                c.ShowDialog();
                this.Show();
                Application.Exit();
            }
        }

       
    }
}
