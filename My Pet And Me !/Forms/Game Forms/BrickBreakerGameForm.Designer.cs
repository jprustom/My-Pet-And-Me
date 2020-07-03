namespace My_Pet_And_Me__
{
    partial class BrickBreakerGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrickBreakerGameForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.createBallInstanceTimer = new System.Windows.Forms.Timer(this.components);
            this.playPetSound = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // createBallInstanceTimer
            // 
            this.createBallInstanceTimer.Enabled = true;
            this.createBallInstanceTimer.Interval = 10000;
            this.createBallInstanceTimer.Tick += new System.EventHandler(this.createBallInstanceTimer_Tick);
            // 
            // playPetSoud
            // 
            this.playPetSound.Enabled = true;
            this.playPetSound.Interval = 10000;
            this.playPetSound.Tick += new System.EventHandler(this.playPetSound_Tick);
            // 
            // BrickBreakerGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::My_Pet_And_Me__.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BrickBreakerGameForm";
            this.Text = "BrickBreakerGameForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BrickBreakerGameForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrickBreakerGameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BrickBreakerGameForm_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer createBallInstanceTimer;
        private System.Windows.Forms.Timer playPetSound;
    }
}