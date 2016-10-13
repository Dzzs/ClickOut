namespace ClickOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.speedSelectLabel = new System.Windows.Forms.Label();
            this.speedSelectBoxes = new System.Windows.Forms.CheckedListBox();
            this.brokenButtonLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deathBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deathBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(449, 94);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(389, 77);
            this.gameOverLabel.TabIndex = 2;
            this.gameOverLabel.Text = "Game Over";
            this.gameOverLabel.Visible = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(570, 185);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(120, 33);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Score: 50";
            this.scoreLabel.Visible = false;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(386, 237);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(528, 26);
            this.startLabel.TabIndex = 4;
            this.startLabel.Text = "Click the boxes to prevent them from reaching the center.";
            // 
            // speedSelectLabel
            // 
            this.speedSelectLabel.AutoSize = true;
            this.speedSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedSelectLabel.Location = new System.Drawing.Point(182, 276);
            this.speedSelectLabel.Name = "speedSelectLabel";
            this.speedSelectLabel.Size = new System.Drawing.Size(175, 25);
            this.speedSelectLabel.TabIndex = 6;
            this.speedSelectLabel.Text = "Choose a speed.";
            // 
            // speedSelectBoxes
            // 
            this.speedSelectBoxes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.speedSelectBoxes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.speedSelectBoxes.CheckOnClick = true;
            this.speedSelectBoxes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedSelectBoxes.FormattingEnabled = true;
            this.speedSelectBoxes.Items.AddRange(new object[] {
            "Slow",
            "Medium",
            "Fast"});
            this.speedSelectBoxes.Location = new System.Drawing.Point(203, 304);
            this.speedSelectBoxes.Name = "speedSelectBoxes";
            this.speedSelectBoxes.Size = new System.Drawing.Size(120, 96);
            this.speedSelectBoxes.TabIndex = 0;
            this.speedSelectBoxes.TabStop = false;
            this.speedSelectBoxes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.speedSelectBoxes_ItemCheck);
            // 
            // brokenButtonLabel
            // 
            this.brokenButtonLabel.AutoSize = true;
            this.brokenButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brokenButtonLabel.Location = new System.Drawing.Point(324, 454);
            this.brokenButtonLabel.Name = "brokenButtonLabel";
            this.brokenButtonLabel.Size = new System.Drawing.Size(680, 20);
            this.brokenButtonLabel.TabIndex = 7;
            this.brokenButtonLabel.Text = "If the restart button doesn\'t work keep clicking until it does. There is nothing " +
    "I can do about that.";
            this.brokenButtonLabel.Visible = false;
            // 
            // startButton
            // 
            this.startButton.BackgroundImage = global::ClickOut.Properties.Resources.neonGreenCursor;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(535, 302);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(210, 113);
            this.startButton.TabIndex = 0;
            this.startButton.TabStop = false;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.startButton_MouseUp);
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.BackgroundImage = global::ClickOut.Properties.Resources.blackCat;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(1202, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 0;
            this.button5.TabStop = false;
            this.button5.Text = "           ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackgroundImage = global::ClickOut.Properties.Resources.blackJackOLantern;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(1202, 647);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 0;
            this.button4.TabStop = false;
            this.button4.Text = "           ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.BackgroundImage = global::ClickOut.Properties.Resources.blackGhost;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(12, 647);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 0;
            this.button3.TabStop = false;
            this.button3.Text = "           ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackgroundImage = global::ClickOut.Properties.Resources.blueGhost;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(68, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "           ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImage = global::ClickOut.Properties.Resources.brownBat;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "           ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown_1);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // deathBox
            // 
            this.deathBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deathBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deathBox.BackgroundImage")));
            this.deathBox.ErrorImage = null;
            this.deathBox.InitialImage = null;
            this.deathBox.Location = new System.Drawing.Point(540, 290);
            this.deathBox.Name = "deathBox";
            this.deathBox.Size = new System.Drawing.Size(200, 140);
            this.deathBox.TabIndex = 0;
            this.deathBox.TabStop = false;
            this.deathBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.brokenButtonLabel);
            this.Controls.Add(this.speedSelectBoxes);
            this.Controls.Add(this.speedSelectLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deathBox);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ClickOut";
            ((System.ComponentModel.ISupportInitialize)(this.deathBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox deathBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label speedSelectLabel;
        private System.Windows.Forms.CheckedListBox speedSelectBoxes;
        private System.Windows.Forms.Label brokenButtonLabel;
    }
}

