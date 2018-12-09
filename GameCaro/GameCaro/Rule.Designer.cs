namespace GameCaro
{
    partial class Rule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rule));
            this.rtbRule = new System.Windows.Forms.RichTextBox();
            this.IgnoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbRule
            // 
            this.rtbRule.AcceptsTab = true;
            this.rtbRule.AutoWordSelection = true;
            this.rtbRule.BulletIndent = 1;
            this.rtbRule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbRule.DetectUrls = false;
            this.rtbRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRule.HideSelection = false;
            this.rtbRule.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtbRule.Location = new System.Drawing.Point(12, 12);
            this.rtbRule.Multiline = false;
            this.rtbRule.Name = "rtbRule";
            this.rtbRule.ShowSelectionMargin = true;
            this.rtbRule.Size = new System.Drawing.Size(367, 348);
            this.rtbRule.TabIndex = 0;
            this.rtbRule.Text = "";
            this.rtbRule.WordWrap = false;
            this.rtbRule.TextChanged += new System.EventHandler(this.rtbRule_TextChanged);
            // 
            // IgnoreButton
            // 
            this.IgnoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IgnoreButton.Location = new System.Drawing.Point(266, 391);
            this.IgnoreButton.Name = "IgnoreButton";
            this.IgnoreButton.Size = new System.Drawing.Size(75, 23);
            this.IgnoreButton.TabIndex = 1;
            this.IgnoreButton.Text = "Đã hiểu";
            this.IgnoreButton.UseVisualStyleBackColor = true;
            this.IgnoreButton.Click += new System.EventHandler(this.IgnoreButton_Click);
            // 
            // Rule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameCaro.Properties.Resources.BackgroundBoard;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.IgnoreButton);
            this.Controls.Add(this.rtbRule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbRule;
        private System.Windows.Forms.Button IgnoreButton;
    }
}