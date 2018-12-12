using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
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
            get { return currentPlayer; }
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


        private StackCaro<InfoPlayer> timeLineStack;
        public StackCaro<InfoPlayer> TimeLineStack
        {
            get { return timeLineStack; }
            set { timeLineStack = value; }
        }

        private int panelWidth;
        public int PanelWidth
        {
            set { panelWidth = value; }
            get { return panelWidth; }
        }

        private int panelHeight;
        public int PanelHeight
        {
            set { panelHeight = value; }
            get { return panelHeight; }
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

        private event EventHandler undoClick;
        public event EventHandler UndoClick
        {
            add
            {
                undoClick += value;
            }
            remove
            {
                undoClick -= value;
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
                new Player("Player01",Image.FromFile(Application.StartupPath + "\\Resources\\x1.PNG")),
                new Player("Player02",Image.FromFile(Application.StartupPath + "\\Resources\\x2.PNG"))
            };
        }
        #endregion

        #region Methods
        public void DrawPanelChessBoard()
        {

            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();

            TimeLineStack = new StackCaro<InfoPlayer>();

            CurrentPlayer = 0;
            ChangePlayer();

            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Size.ChessBoardHeight; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Size.ChessBoardWidth + 1 ; j++)
                {
                    Button button = new Button()
                    {
                        Width = Size.ChessWidth,
                        Height = Size.ChessHeight,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    button.Click += buttonclick;

                    ChessBoard.Controls.Add(button);

                    Matrix[i].Add(button);

                    oldButton = button;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Size.ChessHeight);
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

            TimeLineStack.Push(new InfoPlayer(GetChess(button), CurrentPlayer));

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            if (IsEndGame(button))
            {
                EndGame();
                ChessBoard.Enabled = false;
            }
            else if(TimeLineStack.Count==Size.ChessBoardWidth*Size.ChessBoardHeight)
            {
                MessageBox.Show("Hai người chơi hòa", "Thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ChangePlayer();

            Form1.BoolUndo++;

            EnableUndo();
        }

        public void EnableUndo()
        {
            if (undoClick != null)
                undoClick(this, new EventArgs());
        }

        public bool Undo() {
            if (TimeLineStack.Count <= 0)   {
                MessageBox.Show("Bàn cờ chưa được đi!!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);    
                return false;
            }

            InfoPlayer OldPoint = TimeLineStack.Pop();
            Button button = Matrix[OldPoint.Point.X][OldPoint.Point.Y];

            button.BackgroundImage = null;

            for (int i = 0; i < 10; i++)  {
                button.BackColor = Color.Red;
                Thread.Sleep(40);
                Application.DoEvents();
                button.BackColor = Color.Empty;
            }

            if (TimeLineStack.Count == 0)  {                    
                 CurrentPlayer = 0;
            }  else
            {
                OldPoint = TimeLineStack.Top();
                CurrentPlayer = OldPoint.CurrentPlayer == 1 ? 0 : 1;    
            }

            ChangePlayer();
            Form1.BoolUndo++; 
            return true;
        }

         public void SizePanel()
        {
            PanelHeight = Size.ChessBoardHeight *
                Size.ChessHeight;
            PanelWidth = Size.ChessBoardWidth *
                Size.ChessWidth;

            ChessBoard.Size = new System.Drawing.Size(PanelWidth, PanelHeight);
        }

        public void LocationPanel()
        {
            ChessBoard.Location = new Point(285, 40);
        }

        public void EndGame()
        {

            MessageBox.Show(this.PlayerName.Text + " đã chiến thắng!", "Thông báo",
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
            int row = Convert.ToInt32(button.Tag);
            int col = Matrix[row].IndexOf(button);

            Point point = new Point(row, col);
            return point;
        }

        private bool IsEndRow(Button button)
        {
            Point point = GetChess(button);
            bool chan = false;
            int CountLeft = 0;
            for(int i=point.Y; i>=0; i--)
            {
                if (Matrix[point.X][i].BackgroundImage == button.BackgroundImage)
                    CountLeft++;
                else 
                {
                    if (Matrix[point.X][i].BackgroundImage != null)
                        chan = true;
                    break;
                }
            }

            int CountRight = 0;
            for (int i = point.Y+1; i <Size.ChessBoardWidth; i++)
            {
                if (Matrix[point.X][i].BackgroundImage == button.BackgroundImage)
                    CountRight++;
                else
                {
                    if (chan == true)
                    {
                        if (Matrix[point.X][i].BackgroundImage != null)
                            CountLeft = CountRight = 0;
                    }
                    break;
                }
            }
            return CountLeft + CountRight == Size.LineWin;
        }

        private bool IsEndCol(Button button)
        {
            Point point = GetChess(button);
            bool chan = false;
            int CountTop = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[i][point.Y].BackgroundImage == button.BackgroundImage)
                    CountTop++;
                else 
                {
                    if (Matrix[i][point.Y].BackgroundImage != null)
                        chan = true;
                    break;
                }
            }

            int CountBottom = 0;
            for (int i = point.X + 1; i < Size.ChessBoardHeight; i++)
            {
                if (Matrix[i][point.Y].BackgroundImage == button.BackgroundImage)
                    CountBottom++;
                else
                {
                    if(chan==true)
                    {
                        if (Matrix[i][point.Y].BackgroundImage != null)
                            CountBottom = CountTop = 0;
                    }
                    break;
                }
            }
            return CountTop + CountBottom == Size.LineWin;
        }

        private bool IsEndPrimary(Button button)
        {
            Point point = GetChess(button);
            bool chan = false;

            int CountTop = 0;
            for (int i = 0; i <= point.Y; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.X-i][point.Y-i].BackgroundImage == button.BackgroundImage)
                    CountTop++;
                else 
                {
                    if (Matrix[point.X - i][point.Y - i].BackgroundImage != null)
                        chan = true;
                    break;
                }
            }

            int CountBottom = 0;
            for (int i = 1; i <= Size.ChessBoardWidth-point.Y; i++)
            {
                if (point.X+i >= Size.ChessBoardHeight || point.Y +i>= Size.ChessBoardWidth)
                    break;
                if (Matrix[point.X + i][point.Y + i].BackgroundImage == button.BackgroundImage)
                    CountBottom++;
                else
                {
                    if (chan == true)
                        if (Matrix[point.X + i][point.Y + i].BackgroundImage != null)
                            CountTop = CountBottom = 0;
                    break;
                }
            }
            return CountTop + CountBottom == Size.LineWin;
        }

        private bool IsEndSub(Button button)
        {
            Point point = GetChess(button);
            bool chan = false;
            int CountTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y + i >= Size.ChessBoardWidth+1 )
                    break;
                if (Matrix[point.X - i][point.Y + i].BackgroundImage == button.BackgroundImage)
                    CountTop++;
                else
                {
                    if (Matrix[point.X - i][point.Y + i].BackgroundImage != null)
                        chan = true;
                    break;
                }
            }

            int CountBottom = 0;
            for (int i = 1; i <= Size.ChessBoardWidth +1   - point.Y; i++)
            {
                if (point.X + i >= Size.ChessBoardHeight || point.Y - i < 0)
                    break;
                if (Matrix[point.X + i][point.Y - i].BackgroundImage == button.BackgroundImage)
                    CountBottom++;
                else
                {
                    if (chan == true)
                    {
                        if (Matrix[point.X + i][point.Y - i].BackgroundImage != null)
                            CountTop = CountBottom = 0;
                    }
                    break;
                }
            }
            if(CountBottom+CountTop==Size.LineWin)
            {
                
            }
            return CountTop + CountBottom == Size.LineWin;
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
