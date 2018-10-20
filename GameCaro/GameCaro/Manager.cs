using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public class Manager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        

        private List<Player> player;
        public List<Player> Player
        {
            get { return player; }
            set { player = value; }
        }

        

        private int currentPlayer;
        public int CurrentPlayer
        {
            get {return currentPlayer; }
            set { currentPlayer = value; }
        }

        

        private TextBox playerName;
        public TextBox PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        

        private PictureBox playerMark;
        public PictureBox PlayerMark
        {
            get { return playerMark; }
            set { playerMark = value; }
        }




        #endregion

        #region Initialize
        public Manager(Panel chessBoard,TextBox playerName,PictureBox mark)
        {
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = mark;
            this.Player = new List<Player>()
            {
                new Player("thang",Image.FromFile(Application.StartupPath + "\\Resources\\Capture 02.PNG")),
                new Player("tuong",Image.FromFile(Application.StartupPath + "\\Resources\\Capture.PNG"))
            };
            CurrentPlayer = 0;
            ChangePlayer();
        }
        #endregion

        #region Methods
        public void DrawPanelChessBoard()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Const.ChessBoardHeight; i++)
            {
                for (int j = 0; j < Const.ChessBoardWidth; j++)
                {
                    Button button = new Button()
                    {
                        Width = Const.ChessWidth,
                        Height = Const.ChessHeight,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout=ImageLayout.Stretch
                    };
                    button.Click += buttonclick;
                    ChessBoard.Controls.Add(button);
                    oldButton = button;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Const.ChessHeight);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        void buttonclick(object sender,EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackgroundImage != null)
                return;
            Mark(button);
            ChangePlayer();
           
        }
        private void Mark(Button button)
        {
            button.BackgroundImage = Player[CurrentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

        }

        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }
        #endregion
    }
}
