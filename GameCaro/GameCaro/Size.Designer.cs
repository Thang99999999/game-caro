namespace GameCaro
{
    partial class Size
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Size));
            this.Numrow = new System.Windows.Forms.NumericUpDown();
            this.NumCol = new System.Windows.Forms.NumericUpDown();
            this.OKSizeButton = new System.Windows.Forms.Button();
            this.Button33 = new System.Windows.Forms.Button();
            this.Button55 = new System.Windows.Forms.Button();
            this.Button77 = new System.Windows.Forms.Button();
            this.OtherSizeButton = new System.Windows.Forms.Button();
            this.lblRow = new System.Windows.Forms.Label();
            this.LalCol = new System.Windows.Forms.Label();
            this.panelSwap = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Numrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCol)).BeginInit();
            this.panelSwap.SuspendLayout();
            this.SuspendLayout();
            // 
            // Numrow
            // 
            this.Numrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Numrow.Location = new System.Drawing.Point(107, 49);
            this.Numrow.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Numrow.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Numrow.Name = "Numrow";
            this.Numrow.Size = new System.Drawing.Size(44, 20);
            this.Numrow.TabIndex = 7;
            this.Numrow.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NumCol
            // 
            this.NumCol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NumCol.Location = new System.Drawing.Point(107, 10);
            this.NumCol.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NumCol.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumCol.Name = "NumCol";
            this.NumCol.Size = new System.Drawing.Size(44, 20);
            this.NumCol.TabIndex = 8;
            this.NumCol.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // OKSizeButton
            // 
            this.OKSizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OKSizeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OKSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OKSizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKSizeButton.Location = new System.Drawing.Point(195, 66);
            this.OKSizeButton.Name = "OKSizeButton";
            this.OKSizeButton.Size = new System.Drawing.Size(41, 23);
            this.OKSizeButton.TabIndex = 9;
            this.OKSizeButton.Text = "OK";
            this.OKSizeButton.UseVisualStyleBackColor = false;
            this.OKSizeButton.Click += new System.EventHandler(this.OKSizeButton_Click);
            // 
            // Button33
            // 
            this.Button33.BackgroundImage = global::GameCaro.Properties.Resources._333;
            this.Button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button33.Location = new System.Drawing.Point(208, 170);
            this.Button33.Name = "Button33";
            this.Button33.Size = new System.Drawing.Size(100, 108);
            this.Button33.TabIndex = 10;
            this.Button33.UseVisualStyleBackColor = true;
            this.Button33.Click += new System.EventHandler(this.Button33_Click);
            // 
            // Button55
            // 
            this.Button55.BackgroundImage = global::GameCaro.Properties.Resources._555;
            this.Button55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button55.Location = new System.Drawing.Point(313, 170);
            this.Button55.Name = "Button55";
            this.Button55.Size = new System.Drawing.Size(100, 108);
            this.Button55.TabIndex = 11;
            this.Button55.UseVisualStyleBackColor = true;
            this.Button55.Click += new System.EventHandler(this.Button55_Click);
            // 
            // Button77
            // 
            this.Button77.BackgroundImage = global::GameCaro.Properties.Resources._777;
            this.Button77.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button77.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button77.Location = new System.Drawing.Point(419, 170);
            this.Button77.Name = "Button77";
            this.Button77.Size = new System.Drawing.Size(100, 108);
            this.Button77.TabIndex = 12;
            this.Button77.UseVisualStyleBackColor = true;
            this.Button77.Click += new System.EventHandler(this.Button77_Click);
            // 
            // OtherSizeButton
            // 
            this.OtherSizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OtherSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OtherSizeButton.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherSizeButton.Location = new System.Drawing.Point(208, 315);
            this.OtherSizeButton.Name = "OtherSizeButton";
            this.OtherSizeButton.Size = new System.Drawing.Size(134, 29);
            this.OtherSizeButton.TabIndex = 13;
            this.OtherSizeButton.Text = "Others Size";
            this.OtherSizeButton.UseVisualStyleBackColor = false;
            this.OtherSizeButton.Click += new System.EventHandler(this.OtherSizeButton_Click);
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRow.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRow.ForeColor = System.Drawing.Color.Black;
            this.lblRow.Location = new System.Drawing.Point(3, 11);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(82, 21);
            this.lblRow.TabIndex = 14;
            this.lblRow.Text = "Số dòng";
            // 
            // LalCol
            // 
            this.LalCol.AutoSize = true;
            this.LalCol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LalCol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LalCol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LalCol.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LalCol.ForeColor = System.Drawing.Color.Black;
            this.LalCol.Location = new System.Drawing.Point(3, 47);
            this.LalCol.Name = "LalCol";
            this.LalCol.Size = new System.Drawing.Size(63, 21);
            this.LalCol.TabIndex = 15;
            this.LalCol.Text = "Số Cột";
            // 
            // panelSwap
            // 
            this.panelSwap.BackgroundImage = global::GameCaro.Properties.Resources.PanelSwap;
            this.panelSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSwap.Controls.Add(this.lblRow);
            this.panelSwap.Controls.Add(this.LalCol);
            this.panelSwap.Controls.Add(this.NumCol);
            this.panelSwap.Controls.Add(this.Numrow);
            this.panelSwap.Controls.Add(this.OKSizeButton);
            this.panelSwap.Location = new System.Drawing.Point(338, 350);
            this.panelSwap.Name = "panelSwap";
            this.panelSwap.Size = new System.Drawing.Size(261, 101);
            this.panelSwap.TabIndex = 16;
            // 
            // Size
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GameCaro.Properties.Resources.SizeBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 451);
            this.Controls.Add(this.panelSwap);
            this.Controls.Add(this.OtherSizeButton);
            this.Controls.Add(this.Button77);
            this.Controls.Add(this.Button55);
            this.Controls.Add(this.Button33);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Size";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Size";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Size_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Numrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCol)).EndInit();
            this.panelSwap.ResumeLayout(false);
            this.panelSwap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown Numrow;
        private System.Windows.Forms.NumericUpDown NumCol;
        private System.Windows.Forms.Button OKSizeButton;
        private System.Windows.Forms.Button Button33;
        private System.Windows.Forms.Button Button55;
        private System.Windows.Forms.Button Button77;
        private System.Windows.Forms.Button OtherSizeButton;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label LalCol;
        private System.Windows.Forms.Panel panelSwap;
    }
}