namespace My_Pet_And_Me__
{
    partial class ChooseGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseGameForm));
            this.snakeLabel = new System.Windows.Forms.Label();
            this.pongLabel = new System.Windows.Forms.Label();
            this.chooseGameLabel = new System.Windows.Forms.Label();
            this.brickBreakerGame = new System.Windows.Forms.PictureBox();
            this.pongSnapshot = new System.Windows.Forms.PictureBox();
            this.snakeSnapshotPicBox = new System.Windows.Forms.PictureBox();
            this.brickBreakerLabel = new System.Windows.Forms.Label();
            this.chosenPetPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.brickBreakerGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongSnapshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeSnapshotPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chosenPetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // snakeLabel
            // 
            this.snakeLabel.AutoSize = true;
            this.snakeLabel.BackColor = System.Drawing.Color.White;
            this.snakeLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snakeLabel.ForeColor = System.Drawing.Color.Black;
            this.snakeLabel.Location = new System.Drawing.Point(342, 611);
            this.snakeLabel.Name = "snakeLabel";
            this.snakeLabel.Size = new System.Drawing.Size(193, 64);
            this.snakeLabel.TabIndex = 2;
            this.snakeLabel.Text = "Snake";
            this.snakeLabel.Click += new System.EventHandler(this.snakeSnapshotPicBox_Click);
            // 
            // pongLabel
            // 
            this.pongLabel.AutoSize = true;
            this.pongLabel.BackColor = System.Drawing.Color.Transparent;
            this.pongLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pongLabel.ForeColor = System.Drawing.Color.White;
            this.pongLabel.Location = new System.Drawing.Point(587, 375);
            this.pongLabel.Name = "pongLabel";
            this.pongLabel.Size = new System.Drawing.Size(226, 64);
            this.pongLabel.TabIndex = 3;
            this.pongLabel.Text = "Soccer";
            // 
            // chooseGameLabel
            // 
            this.chooseGameLabel.AutoSize = true;
            this.chooseGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.chooseGameLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseGameLabel.ForeColor = System.Drawing.Color.White;
            this.chooseGameLabel.Location = new System.Drawing.Point(1, 28);
            this.chooseGameLabel.Name = "chooseGameLabel";
            this.chooseGameLabel.Size = new System.Drawing.Size(775, 96);
            this.chooseGameLabel.TabIndex = 4;
            this.chooseGameLabel.Text = "Choose A Game !";
            // 
            // brickBreakerGame
            // 
            this.brickBreakerGame.BackColor = System.Drawing.Color.Transparent;
            this.brickBreakerGame.Image = global::My_Pet_And_Me__.Properties.Resources.brickBreakerSnapshot;
            this.brickBreakerGame.Location = new System.Drawing.Point(-9, 187);
            this.brickBreakerGame.Name = "brickBreakerGame";
            this.brickBreakerGame.Size = new System.Drawing.Size(478, 185);
            this.brickBreakerGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brickBreakerGame.TabIndex = 5;
            this.brickBreakerGame.TabStop = false;
            this.brickBreakerGame.Click += new System.EventHandler(this.brickBreakerGame_Click);
            // 
            // pongSnapshot
            // 
            this.pongSnapshot.BackColor = System.Drawing.Color.Transparent;
            this.pongSnapshot.Image = global::My_Pet_And_Me__.Properties.Resources.pongSnapshot;
            this.pongSnapshot.Location = new System.Drawing.Point(526, 187);
            this.pongSnapshot.Name = "pongSnapshot";
            this.pongSnapshot.Size = new System.Drawing.Size(342, 185);
            this.pongSnapshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pongSnapshot.TabIndex = 1;
            this.pongSnapshot.TabStop = false;
            this.pongSnapshot.Click += new System.EventHandler(this.pongSnapshot_Click);
            // 
            // snakeSnapshotPicBox
            // 
            this.snakeSnapshotPicBox.BackColor = System.Drawing.Color.Transparent;
            this.snakeSnapshotPicBox.Image = global::My_Pet_And_Me__.Properties.Resources.snapshot;
            this.snakeSnapshotPicBox.Location = new System.Drawing.Point(113, 442);
            this.snakeSnapshotPicBox.Name = "snakeSnapshotPicBox";
            this.snakeSnapshotPicBox.Size = new System.Drawing.Size(663, 376);
            this.snakeSnapshotPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.snakeSnapshotPicBox.TabIndex = 0;
            this.snakeSnapshotPicBox.TabStop = false;
            this.snakeSnapshotPicBox.Click += new System.EventHandler(this.snakeSnapshotPicBox_Click);
            // 
            // brickBreakerLabel
            // 
            this.brickBreakerLabel.AutoSize = true;
            this.brickBreakerLabel.BackColor = System.Drawing.Color.Transparent;
            this.brickBreakerLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brickBreakerLabel.ForeColor = System.Drawing.Color.White;
            this.brickBreakerLabel.Location = new System.Drawing.Point(70, 375);
            this.brickBreakerLabel.Name = "brickBreakerLabel";
            this.brickBreakerLabel.Size = new System.Drawing.Size(345, 48);
            this.brickBreakerLabel.TabIndex = 6;
            this.brickBreakerLabel.Text = "Brick Breaker";
            // 
            // chosenPetPictureBox
            // 
            this.chosenPetPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.chosenPetPictureBox.Image = global::My_Pet_And_Me__.Properties.Resources.turtle;
            this.chosenPetPictureBox.Location = new System.Drawing.Point(743, 41);
            this.chosenPetPictureBox.Name = "chosenPetPictureBox";
            this.chosenPetPictureBox.Size = new System.Drawing.Size(161, 112);
            this.chosenPetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chosenPetPictureBox.TabIndex = 8;
            this.chosenPetPictureBox.TabStop = false;
            // 
            // ChooseGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::My_Pet_And_Me__.Properties.Resources.Choose_Game_Background;
            this.ClientSize = new System.Drawing.Size(911, 859);
            this.Controls.Add(this.snakeLabel);
            this.Controls.Add(this.brickBreakerLabel);
            this.Controls.Add(this.pongLabel);
            this.Controls.Add(this.pongSnapshot);
            this.Controls.Add(this.snakeSnapshotPicBox);
            this.Controls.Add(this.chosenPetPictureBox);
            this.Controls.Add(this.brickBreakerGame);
            this.Controls.Add(this.chooseGameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ChooseGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseGameForm";
            ((System.ComponentModel.ISupportInitialize)(this.brickBreakerGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongSnapshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeSnapshotPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chosenPetPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox snakeSnapshotPicBox;
        private System.Windows.Forms.PictureBox pongSnapshot;
        private System.Windows.Forms.Label snakeLabel;
        private System.Windows.Forms.Label pongLabel;
        private System.Windows.Forms.Label chooseGameLabel;
        private System.Windows.Forms.PictureBox brickBreakerGame;
        private System.Windows.Forms.Label brickBreakerLabel;
        private System.Windows.Forms.PictureBox chosenPetPictureBox;
    }
}