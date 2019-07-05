namespace Snake
{
    partial class SnakeGame
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
            this.startButton = new System.Windows.Forms.Button();
            this.gameArea = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.speedSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.baitLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(682, 471);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(109, 42);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.Color.LavenderBlush;
            this.gameArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameArea.Location = new System.Drawing.Point(12, 12);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(664, 548);
            this.gameArea.TabIndex = 1;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.resetButton.Location = new System.Drawing.Point(682, 370);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(109, 23);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "New Game";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // speedSelection
            // 
            this.speedSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedSelection.FormattingEnabled = true;
            this.speedSelection.Items.AddRange(new object[] {
            "1 - Very Easy",
            "2 - Easy",
            "3 - Medium",
            "4 - Hard",
            "5 - Very Hard",
            "6 - İmpossible"});
            this.speedSelection.Location = new System.Drawing.Point(682, 414);
            this.speedSelection.Name = "speedSelection";
            this.speedSelection.Size = new System.Drawing.Size(109, 21);
            this.speedSelection.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(692, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Points :";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.White;
            this.scoreLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreLabel.Location = new System.Drawing.Point(767, 46);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(15, 16);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(692, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eaten : ";
            // 
            // baitLabel
            // 
            this.baitLabel.AutoSize = true;
            this.baitLabel.BackColor = System.Drawing.Color.White;
            this.baitLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baitLabel.Location = new System.Drawing.Point(767, 12);
            this.baitLabel.Name = "baitLabel";
            this.baitLabel.Size = new System.Drawing.Size(15, 16);
            this.baitLabel.TabIndex = 7;
            this.baitLabel.Text = "0";
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.baitLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedSelection);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.gameArea);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.SnakeGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox speedSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label baitLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

