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
            this.RButton3 = new System.Windows.Forms.RadioButton();
            this.RButton5 = new System.Windows.Forms.RadioButton();
            this.RButton9 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Numrow = new System.Windows.Forms.NumericUpDown();
            this.NumCol = new System.Windows.Forms.NumericUpDown();
            this.OKSizeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.RBOption = new System.Windows.Forms.RadioButton();
            this.RBStandart = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Numrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCol)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // RButton3
            // 
            this.RButton3.AllowDrop = true;
            this.RButton3.AutoSize = true;
            this.RButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RButton3.Location = new System.Drawing.Point(19, 15);
            this.RButton3.Name = "RButton3";
            this.RButton3.Size = new System.Drawing.Size(42, 17);
            this.RButton3.TabIndex = 1;
            this.RButton3.Text = "3x3";
            this.RButton3.UseVisualStyleBackColor = true;
            this.RButton3.CheckedChanged += new System.EventHandler(this.RButton3_CheckedChanged);
            // 
            // RButton5
            // 
            this.RButton5.AllowDrop = true;
            this.RButton5.AutoSize = true;
            this.RButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RButton5.Location = new System.Drawing.Point(19, 82);
            this.RButton5.Name = "RButton5";
            this.RButton5.Size = new System.Drawing.Size(42, 17);
            this.RButton5.TabIndex = 2;
            this.RButton5.Text = "5x5";
            this.RButton5.UseVisualStyleBackColor = true;
            this.RButton5.CheckedChanged += new System.EventHandler(this.RButton3_CheckedChanged);
            // 
            // RButton9
            // 
            this.RButton9.AllowDrop = true;
            this.RButton9.AutoSize = true;
            this.RButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RButton9.Location = new System.Drawing.Point(19, 148);
            this.RButton9.Name = "RButton9";
            this.RButton9.Size = new System.Drawing.Size(42, 17);
            this.RButton9.TabIndex = 3;
            this.RButton9.Text = "9x9";
            this.RButton9.UseVisualStyleBackColor = true;
            this.RButton9.CheckedChanged += new System.EventHandler(this.RButton3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số dòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số cột";
            // 
            // Numrow
            // 
            this.Numrow.Location = new System.Drawing.Point(209, 311);
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
            this.Numrow.Size = new System.Drawing.Size(55, 20);
            this.Numrow.TabIndex = 7;
            this.Numrow.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NumCol
            // 
            this.NumCol.Location = new System.Drawing.Point(209, 353);
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
            this.NumCol.Size = new System.Drawing.Size(55, 20);
            this.NumCol.TabIndex = 8;
            this.NumCol.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // OKSizeButton
            // 
            this.OKSizeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OKSizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKSizeButton.Location = new System.Drawing.Point(309, 415);
            this.OKSizeButton.Name = "OKSizeButton";
            this.OKSizeButton.Size = new System.Drawing.Size(75, 23);
            this.OKSizeButton.TabIndex = 9;
            this.OKSizeButton.Text = "OK";
            this.OKSizeButton.UseVisualStyleBackColor = true;
            this.OKSizeButton.Click += new System.EventHandler(this.OKSizeButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RButton3);
            this.panel2.Controls.Add(this.RButton5);
            this.panel2.Controls.Add(this.RButton9);
            this.panel2.Location = new System.Drawing.Point(190, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 169);
            this.panel2.TabIndex = 13;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.RBOption);
            this.pnlMain.Controls.Add(this.RBStandart);
            this.pnlMain.Location = new System.Drawing.Point(12, 46);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(136, 269);
            this.pnlMain.TabIndex = 14;
            // 
            // RBOption
            // 
            this.RBOption.AutoSize = true;
            this.RBOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBOption.Location = new System.Drawing.Point(17, 223);
            this.RBOption.Name = "RBOption";
            this.RBOption.Size = new System.Drawing.Size(103, 24);
            this.RBOption.TabIndex = 1;
            this.RBOption.TabStop = true;
            this.RBOption.Text = "Tùy chỉnh";
            this.RBOption.UseVisualStyleBackColor = true;
            this.RBOption.CheckedChanged += new System.EventHandler(this.RBOption_CheckedChanged);
            // 
            // RBStandart
            // 
            this.RBStandart.AutoSize = true;
            this.RBStandart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBStandart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBStandart.Location = new System.Drawing.Point(17, 31);
            this.RBStandart.Name = "RBStandart";
            this.RBStandart.Size = new System.Drawing.Size(103, 24);
            this.RBStandart.TabIndex = 0;
            this.RBStandart.TabStop = true;
            this.RBStandart.Text = "Chọn sẵn";
            this.RBStandart.UseVisualStyleBackColor = true;
            this.RBStandart.CheckedChanged += new System.EventHandler(this.RBOption_CheckedChanged);
            // 
            // Size
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OKSizeButton);
            this.Controls.Add(this.NumCol);
            this.Controls.Add(this.Numrow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Size";
            this.Text = "Size";
            ((System.ComponentModel.ISupportInitialize)(this.Numrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCol)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RButton3;
        private System.Windows.Forms.RadioButton RButton5;
        private System.Windows.Forms.RadioButton RButton9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Numrow;
        private System.Windows.Forms.NumericUpDown NumCol;
        private System.Windows.Forms.Button OKSizeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.RadioButton RBOption;
        private System.Windows.Forms.RadioButton RBStandart;
    }
}