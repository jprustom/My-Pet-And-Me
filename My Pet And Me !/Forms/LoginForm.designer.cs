namespace My_Pet_And_Me__
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.enterYourNameLabel = new System.Windows.Forms.Label();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.BackColor = System.Drawing.Color.Ivory;
            this.playerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.playerNameTextBox.Location = new System.Drawing.Point(80, 57);
            this.playerNameTextBox.MaxLength = 9;
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(185, 47);
            this.playerNameTextBox.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(119, 195);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(93, 48);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "OK";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // enterYourNameLabel
            // 
            this.enterYourNameLabel.AutoSize = true;
            this.enterYourNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.enterYourNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterYourNameLabel.ForeColor = System.Drawing.Color.Black;
            this.enterYourNameLabel.Location = new System.Drawing.Point(55, 9);
            this.enterYourNameLabel.Name = "enterYourNameLabel";
            this.enterYourNameLabel.Size = new System.Drawing.Size(237, 31);
            this.enterYourNameLabel.TabIndex = 2;
            this.enterYourNameLabel.Text = "Enter Your Name";
            // 
            // ageComboBox
            // 
            this.ageComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.ageComboBox.Location = new System.Drawing.Point(107, 124);
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(121, 39);
            this.ageComboBox.TabIndex = 4;
            this.ageComboBox.Text = "Age";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.BackgroundImage = global::My_Pet_And_Me__.Properties.Resources.Menu_Background;
            this.ClientSize = new System.Drawing.Size(370, 255);
            this.Controls.Add(this.ageComboBox);
            this.Controls.Add(this.enterYourNameLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.playerNameTextBox);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login Please...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label enterYourNameLabel;
        private System.Windows.Forms.ComboBox ageComboBox;
    }
}