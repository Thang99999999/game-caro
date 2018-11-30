using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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

       
        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }


        private Stack<InfoPlayer> playTimeLine;
        public Stack<InfoPlayer> PlayTimeLine
        {
            get { return  playTimeLine; }
            set { playTimeLine = value; }
        }


        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
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
                new Player("Player1",Image.FromFile(Application.StartupPath + "\\Resources\\Capture 02.PNG")),
                new Player("Player2",Image.FromFile(Application.StartupPath + "\\Resources\\Capture.PNG"))
            };
        }
        #endregion

        #region Methods
        public void DrawPanelChessBoard()
        {
            
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();

            PlayTimeLine = new Stack<InfoPlayer>();

            CurrentPlayer = 0;
            ChangePlayer();

            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Const.ChessBoardHeight; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Const.ChessBoardWidth; j++)
                {
                    Button button = new Button()
                    {
                        Width = Const.ChessWidth,
                        Height = Const.ChessHeight,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    button.Click += buttonclick;

                    ChessBoard.Controls.Add(button);

                    Matrix[i].Add(button);

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

            PlayTimeLine.Push(new InfoPlayer(GetChess(button), CurrentPlayer));

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            if (IsEndGame(button))
            {
                EndGame();
                ChessBoard.Enabled = false;
            }

            ChangePlayer();
        }

        public bool Undo()
        {
            if (PlayTimeLine.Count <= 0)
            {
                MessageBox.Show("Bàn cờ chưa được đi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            InfoPlayer OldPoint = PlayTimeLine.Pop();
            Button button = Matrix[OldPoint.Point.Y][OldPoint.Point.X];

            button.BackgroundImage = null;
            
            if (PlayTimeLine.Count == 0)
            {                    
                 CurrentPlayer = 0;
            }
            else
            {
                OldPoint = PlayTimeLine.Peek();
                CurrentPlayer = OldPoint.CurrentPlayer == 1 ? 0 : 1;    
            }

            ChangePlayer();

            return true;
        }

        public void EndGame()
        {
            bool check = true;
            for(int i=0;i<Const.ChessBoardHeight;i++)
                for(int j=0;j<Const.ChessBoardWidth;j++)
                {
                    if (Matrix[i][j].BackgroundImage == null)
                        check = false;
                }
            if (check == false)
                MessageBox.Show(this.PlayerName.Text + " đã chiến thắng!", "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Hai người chơi hòa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }

        private bool IsEndGame(Button button)
        {
            return IsEndRow(button) || IsEndCol(button) || IsEndPrimary(button) || IsEndSub(button);
        }

        private Point GetChess(Button button)
        {
            int col = Convert.ToInt32(button.Tag);
            int row = Matrix[col].IndexOf(button);

            Point point = new Point(row, col);
            return point;
        }

        private bool IsEndRow(Button button)
        {
            Point point = GetChess(button);
            bool chan = false;
            int CountLeft = 0;
            for(int i=point.X; i>=0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == button.BackgroundImage)
                    CountLeft++;
                else 
                {
                    if (Matrix[point.Y][i].BackgroundImage != null)
                        chan = true;
                    break;
                }
            }

            int CountRight = 0;
            for (int i = point.X+1; i <Const.ChessBoardWidth; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == button.BackgroundImage)
                    CountRight++;
                else
                {
                    if (chan == true)
                    {
                        if (Matrix[point.Y][i].BackgroundImage != null)
                            CountLeft = CountRight = 0;
                    }
                    break;
                }
            }
            return CountLeft + CountRight == 5;
        }

        private bool IsEndCol(Button button)
        {
            Point point = GetChess(button);
            bool chan = false;
            int CountTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == button.BackgroundImage)
                    CountTop++;
                else 
                {
                    if (Matrix[i][point.X].BackgroundImage != null)
                        chan = true;
                    break;
                }
            }

            int CountBottom = 0;
            for (int i = point.Y + 1; i < Const.ChessBoardHeight; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == button.BackgroundImage)
                    CountBottom++;
                else
                {
                    if(chan==true)
                    {
                        if (Matrix[i][point.X].BackgroundImage != null)
                            CountBottom = CountTop = 0;
                    }
                    break;
                }
            }
            return CountTop + CountBottom == 5;
        }

        private bool IsEndPrimary(Button button)
        {
            Point point = GetChess(button);
            bool chan = false;
            int CountTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.Y - i < 0 || point.X - i < 0)
                    break;
                if (Matrix[point.Y-i][point.X-i].BackgroundImage == button.BackgroundImage)
                    CountTop++;
                else 
                {
                    if (Matrix[point.Y - i][point.X - i].BackgroundImage != null)
                        chan = true;
                    break;
                }
            }

            int CountBottom = 0;
            for (int i = 1; i <= Const.ChessBoardWidth-point.X; i++)
            {
                if (point.Y+i >= Const.ChessBoardHeight || point.X +i>= Const.ChessBoardWidth)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == button.BackgroundImage)
                    CountBottom++;
                else
                {
                    if (chan == true)
                        if (Matrix[point.Y + i][point.X + i].BackgroundImage != null)
                            CountTop = CountBottom = 0;
                    break;
                }
            }
            return CountTop + CountBottom == 5;
        }
 
        private bool IsEndSub(Button button)
        {
            Point point = GetChess(button);
            bool chan = false;
            int CountTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.Y - i < 0 || point.X + i >=Const.ChessBoardWidth)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == button.BackgroundImage)
                    CountTop++;
                else 
                {
                    if (Matrix[point.Y - i][point.X + i].BackgroundImage != null)
                        chan = true;
                    break;
                }
            }

            int CountBottom = 0;
            for (int i = 1; i <= Const.ChessBoardWidth - point.X; i++)
            {
                if (point.Y + i >= Const.ChessBoardHeight || point.X - i <0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == button.BackgroundImage)
                    CountBottom++;
                else
                {
                    if (chan == true)
                    {
                        if (Matrix[point.Y + i][point.X - i].BackgroundImage != null)
                            CountTop = CountBottom = 0;
                    }
                    break;
                }
            }
            return CountTop + CountBottom == 5;
        }




        private void Mark(Button button)
        {
            button.BackgroundImage = Player[CurrentPlayer].Mark;

        }


        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }
        #endregion
    }
}
