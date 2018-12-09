namespace GameCaro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UndoButton = new System.Windows.Forms.Button();
            this.PictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelChessBoard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.Rule = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.toolTipNG = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlayer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.UndoButton);
            this.panel2.Controls.Add(this.PictureBoxPlayer);
            this.panel2.Controls.Add(this.TextBoxName);
            this.panel2.Location = new System.Drawing.Point(12, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 140);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(157, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Undo";
            // 
            // UndoButton
            // 
            this.UndoButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UndoButton.BackgroundImage = global::GameCaro.Properties.Resources.UndoImage;
            this.UndoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UndoButton.Location = new System.Drawing.Point(141, 53);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(66, 50);
            this.UndoButton.TabIndex = 3;
            this.UndoButton.UseVisualStyleBackColor = false;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // PictureBoxPlayer
            // 
            this.PictureBoxPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PictureBoxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxPlayer.Location = new System.Drawing.Point(3, 33);
            this.PictureBoxPlayer.Name = "PictureBoxPlayer";
            this.PictureBoxPlayer.Size = new System.Drawing.Size(105, 104);
            this.PictureBoxPlayer.TabIndex = 5;
            this.PictureBoxPlayer.TabStop = false;
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxName.Location = new System.Drawing.Point(26, 7);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.ReadOnly = true;
            this.TextBoxName.Size = new System.Drawing.Size(68, 20);
            this.TextBoxName.TabIndex = 0;
            this.TextBoxName.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.sizeBoardToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // sizeBoardToolStripMenuItem
            // 
            this.sizeBoardToolStripMenuItem.Name = "sizeBoardToolStripMenuItem";
            this.sizeBoardToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sizeBoardToolStripMenuItem.Text = "SizeBoard          Ctrl+S";
            this.sizeBoardToolStripMenuItem.Click += new System.EventHandler(this.sizeBoardToolStripMenuItem_Click);
            // 
            // PanelChessBoard
            // 
            this.PanelChessBoard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PanelChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.PanelChessBoard.BackgroundImage = global::GameCaro.Properties.Resources.BackgroundBoard;
            this.PanelChessBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelChessBoard.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelChessBoard.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelChessBoard.Location = new System.Drawing.Point(269, 43);
            this.PanelChessBoard.Name = "PanelChessBoard";
            this.PanelChessBoard.Size = new System.Drawing.Size(567, 540);
            this.PanelChessBoard.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PictureBoxAvatar);
            this.panel1.Location = new System.Drawing.Point(15, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 211);
            this.panel1.TabIndex = 0;
            // 
            // PictureBoxAvatar
            // 
            this.PictureBoxAvatar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PictureBoxAvatar.BackgroundImage = global::GameCaro.Properties.Resources.th4A2MBMRK;
            this.PictureBoxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxAvatar.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxAvatar.Name = "PictureBoxAvatar";
            this.PictureBoxAvatar.Size = new System.Drawing.Size(226, 211);
            this.PictureBoxAvatar.TabIndex = 0;
            this.PictureBoxAvatar.TabStop = false;
            // 
            // Rule
            // 
            this.Rule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rule.Location = new System.Drawing.Point(11, 463);
            this.Rule.Name = "Rule";
            this.Rule.Size = new System.Drawing.Size(72, 23);
            this.Rule.TabIndex = 4;
            this.Rule.Text = "Luật chơi";
            this.Rule.UseVisualStyleBackColor = true;
            this.Rule.Click += new System.EventHandler(this.Rule_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(89, 463);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(75, 23);
            this.NewGameButton.TabIndex = 5;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(170, 463);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 6;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // toolTipNG
            // 
            this.toolTipNG.AutoPopDelay = 500;
            this.toolTipNG.InitialDelay = 500;
            this.toolTipNG.OwnerDraw = true;
            this.toolTipNG.ReshowDelay = 100;
            this.toolTipNG.ShowAlways = true;
            this.toolTipNG.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipNG.ToolTipTitle = "Ctrl+A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 622);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.Rule);
            this.Controls.Add(this.PanelChessBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlayer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PictureBoxPlayer;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Panel PanelChessBoard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBoxAvatar;
        private System.Windows.Forms.Button Rule;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.ToolTip toolTipNG;
        private System.Windows.Forms.ToolStripMenuItem sizeBoardToolStripMenuItem;
    }
}

