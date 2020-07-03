namespace My_Pet_And_Me__
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.loadPlayerBtn = new System.Windows.Forms.Button();
            this.deletePlayerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyListBox
            // 
            this.historyListBox.BackColor = System.Drawing.Color.SpringGreen;
            this.historyListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyListBox.ForeColor = System.Drawing.Color.White;
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 31;
            this.historyListBox.Location = new System.Drawing.Point(-3, 2);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(626, 221);
            this.historyListBox.TabIndex = 0;
            // 
            // newGameBtn
            // 
            this.newGameBtn.BackColor = System.Drawing.Color.LightGreen;
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.newGameBtn.Location = new System.Drawing.Point(134, 328);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(345, 51);
            this.newGameBtn.TabIndex = 1;
            this.newGameBtn.Text = "NEW GAME";
            this.newGameBtn.UseVisualStyleBackColor = false;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // loadPlayerBtn
            // 
            this.loadPlayerBtn.BackColor = System.Drawing.Color.LightGreen;
            this.loadPlayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPlayerBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.loadPlayerBtn.Location = new System.Drawing.Point(164, 282);
            this.loadPlayerBtn.Name = "loadPlayerBtn";
            this.loadPlayerBtn.Size = new System.Drawing.Size(285, 40);
            this.loadPlayerBtn.TabIndex = 2;
            this.loadPlayerBtn.Text = "LOAD";
            this.loadPlayerBtn.UseVisualStyleBackColor = false;
            this.loadPlayerBtn.Click += new System.EventHandler(this.loadPlayerBtn_Click);
            // 
            // deletePlayerBtn
            // 
            this.deletePlayerBtn.BackColor = System.Drawing.Color.LightGreen;
            this.deletePlayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePlayerBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.deletePlayerBtn.Location = new System.Drawing.Point(185, 240);
            this.deletePlayerBtn.Name = "deletePlayerBtn";
            this.deletePlayerBtn.Size = new System.Drawing.Size(247, 36);
            this.deletePlayerBtn.TabIndex = 3;
            this.deletePlayerBtn.Text = "DELETE";
            this.deletePlayerBtn.UseVisualStyleBackColor = false;
            this.deletePlayerBtn.Click += new System.EventHandler(this.deletePlayerBtn_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(614, 392);
            this.Controls.Add(this.deletePlayerBtn);
            this.Controls.Add(this.loadPlayerBtn);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.historyListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistoryForm";
            this.Text = "Welcome !";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HistoryForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button loadPlayerBtn;
        private System.Windows.Forms.Button deletePlayerBtn;
    }
}