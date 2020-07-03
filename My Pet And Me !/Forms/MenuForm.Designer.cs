namespace My_Pet_And_Me__
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.catPicBox = new System.Windows.Forms.PictureBox();
            this.turtlePicBox = new System.Windows.Forms.PictureBox();
            this.foxPicBox = new System.Windows.Forms.PictureBox();
            this.birdPicBox = new System.Windows.Forms.PictureBox();
            this.rabbitPicBox = new System.Windows.Forms.PictureBox();
            this.dogPicBox = new System.Windows.Forms.PictureBox();
            this.snakePicBox = new System.Windows.Forms.PictureBox();
            this.minimizeHistoryFormTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCurrentGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.catPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turtlePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabbitPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakePicBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(66, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(498, 64);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "My Pet And Me !";
            // 
            // catPicBox
            // 
            this.catPicBox.BackColor = System.Drawing.Color.Transparent;
            this.catPicBox.Image = global::My_Pet_And_Me__.Properties.Resources.cat;
            this.catPicBox.Location = new System.Drawing.Point(455, 282);
            this.catPicBox.Name = "catPicBox";
            this.catPicBox.Size = new System.Drawing.Size(155, 136);
            this.catPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catPicBox.TabIndex = 6;
            this.catPicBox.TabStop = false;
            this.catPicBox.Click += new System.EventHandler(this.petPicBox_Click);
            // 
            // turtlePicBox
            // 
            this.turtlePicBox.BackColor = System.Drawing.Color.Transparent;
            this.turtlePicBox.Image = global::My_Pet_And_Me__.Properties.Resources.turtle;
            this.turtlePicBox.Location = new System.Drawing.Point(333, 323);
            this.turtlePicBox.Name = "turtlePicBox";
            this.turtlePicBox.Size = new System.Drawing.Size(116, 95);
            this.turtlePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.turtlePicBox.TabIndex = 7;
            this.turtlePicBox.TabStop = false;
            this.turtlePicBox.Click += new System.EventHandler(this.petPicBox_Click);
            // 
            // foxPicBox
            // 
            this.foxPicBox.BackColor = System.Drawing.Color.Transparent;
            this.foxPicBox.Image = global::My_Pet_And_Me__.Properties.Resources.fox;
            this.foxPicBox.Location = new System.Drawing.Point(103, 295);
            this.foxPicBox.Name = "foxPicBox";
            this.foxPicBox.Size = new System.Drawing.Size(131, 86);
            this.foxPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foxPicBox.TabIndex = 8;
            this.foxPicBox.TabStop = false;
            this.foxPicBox.Click += new System.EventHandler(this.petPicBox_Click);
            // 
            // birdPicBox
            // 
            this.birdPicBox.BackColor = System.Drawing.Color.Transparent;
            this.birdPicBox.Image = global::My_Pet_And_Me__.Properties.Resources.bird;
            this.birdPicBox.Location = new System.Drawing.Point(455, 101);
            this.birdPicBox.Name = "birdPicBox";
            this.birdPicBox.Size = new System.Drawing.Size(139, 74);
            this.birdPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.birdPicBox.TabIndex = 9;
            this.birdPicBox.TabStop = false;
            this.birdPicBox.Click += new System.EventHandler(this.petPicBox_Click);
            // 
            // rabbitPicBox
            // 
            this.rabbitPicBox.BackColor = System.Drawing.Color.Transparent;
            this.rabbitPicBox.Image = global::My_Pet_And_Me__.Properties.Resources.rabbit;
            this.rabbitPicBox.Location = new System.Drawing.Point(494, 198);
            this.rabbitPicBox.Name = "rabbitPicBox";
            this.rabbitPicBox.Size = new System.Drawing.Size(116, 68);
            this.rabbitPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rabbitPicBox.TabIndex = 10;
            this.rabbitPicBox.TabStop = false;
            this.rabbitPicBox.Click += new System.EventHandler(this.petPicBox_Click);
            // 
            // dogPicBox
            // 
            this.dogPicBox.BackColor = System.Drawing.Color.Transparent;
            this.dogPicBox.Image = global::My_Pet_And_Me__.Properties.Resources.dog;
            this.dogPicBox.Location = new System.Drawing.Point(269, 160);
            this.dogPicBox.Name = "dogPicBox";
            this.dogPicBox.Size = new System.Drawing.Size(115, 75);
            this.dogPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dogPicBox.TabIndex = 11;
            this.dogPicBox.TabStop = false;
            this.dogPicBox.Click += new System.EventHandler(this.petPicBox_Click);
            // 
            // snakePicBox
            // 
            this.snakePicBox.BackColor = System.Drawing.Color.Transparent;
            this.snakePicBox.Image = global::My_Pet_And_Me__.Properties.Resources.snake;
            this.snakePicBox.Location = new System.Drawing.Point(12, 282);
            this.snakePicBox.Name = "snakePicBox";
            this.snakePicBox.Size = new System.Drawing.Size(100, 50);
            this.snakePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.snakePicBox.TabIndex = 12;
            this.snakePicBox.TabStop = false;
            this.snakePicBox.Click += new System.EventHandler(this.petPicBox_Click);
            // 
            // minimizeHistoryFormTimer
            // 
            this.minimizeHistoryFormTimer.Enabled = true;
            this.minimizeHistoryFormTimer.Interval = 1;
            this.minimizeHistoryFormTimer.Tick += new System.EventHandler(this.minimizeHistoryFormTimer_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.audioToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(599, 44);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeCurrentGameToolStripMenuItem});
            this.gameToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(110, 40);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // closeCurrentGameToolStripMenuItem
            // 
            this.closeCurrentGameToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.closeCurrentGameToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeCurrentGameToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.closeCurrentGameToolStripMenuItem.Name = "closeCurrentGameToolStripMenuItem";
            this.closeCurrentGameToolStripMenuItem.Size = new System.Drawing.Size(307, 32);
            this.closeCurrentGameToolStripMenuItem.Text = "Close Current Game";
            this.closeCurrentGameToolStripMenuItem.Click += new System.EventHandler(this.closeCurrentGameToolStripMenuItem_Click);
            // 
            // audioToolStripMenuItem
            // 
            this.audioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeMusicToolStripMenuItem,
            this.muteToolStripMenuItem});
            this.audioToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            this.audioToolStripMenuItem.Size = new System.Drawing.Size(113, 40);
            this.audioToolStripMenuItem.Text = "Audio";
            // 
            // changeMusicToolStripMenuItem
            // 
            this.changeMusicToolStripMenuItem.Name = "changeMusicToolStripMenuItem";
            this.changeMusicToolStripMenuItem.Size = new System.Drawing.Size(283, 38);
            this.changeMusicToolStripMenuItem.Text = "Change Music";
            this.changeMusicToolStripMenuItem.Click += new System.EventHandler(this.changeMusicToolStripMenuItem_Click);
            // 
            // muteToolStripMenuItem
            // 
            this.muteToolStripMenuItem.Name = "muteToolStripMenuItem";
            this.muteToolStripMenuItem.Size = new System.Drawing.Size(283, 38);
            this.muteToolStripMenuItem.Text = "Mute";
            this.muteToolStripMenuItem.Click += new System.EventHandler(this.muteToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(158, 394);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.mediaPlayer.TabIndex = 14;
            this.mediaPlayer.Visible = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::My_Pet_And_Me__.Properties.Resources.Menu_Background;
            this.ClientSize = new System.Drawing.Size(599, 421);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.snakePicBox);
            this.Controls.Add(this.dogPicBox);
            this.Controls.Add(this.rabbitPicBox);
            this.Controls.Add(this.birdPicBox);
            this.Controls.Add(this.foxPicBox);
            this.Controls.Add(this.turtlePicBox);
            this.Controls.Add(this.catPicBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.catPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turtlePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabbitPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakePicBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox catPicBox;
        private System.Windows.Forms.PictureBox turtlePicBox;
        private System.Windows.Forms.PictureBox foxPicBox;
        private System.Windows.Forms.PictureBox birdPicBox;
        private System.Windows.Forms.PictureBox rabbitPicBox;
        private System.Windows.Forms.PictureBox dogPicBox;
        private System.Windows.Forms.PictureBox snakePicBox;
        private System.Windows.Forms.Timer minimizeHistoryFormTimer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentGameToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.ToolStripMenuItem audioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muteToolStripMenuItem;
    }
}