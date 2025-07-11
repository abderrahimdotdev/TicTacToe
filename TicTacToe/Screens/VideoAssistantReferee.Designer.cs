namespace TicTacToe.Screens
{
    partial class VideoAssistantReferee
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
            this.listPlayedGames = new System.Windows.Forms.ListBox();
            this.cmbFileNames = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPlayedGames
            // 
            this.listPlayedGames.FormattingEnabled = true;
            this.listPlayedGames.Location = new System.Drawing.Point(554, 79);
            this.listPlayedGames.Name = "listPlayedGames";
            this.listPlayedGames.Size = new System.Drawing.Size(209, 212);
            this.listPlayedGames.TabIndex = 0;
            // 
            // cmbFileNames
            // 
            this.cmbFileNames.FormattingEnabled = true;
            this.cmbFileNames.Location = new System.Drawing.Point(593, 42);
            this.cmbFileNames.Name = "cmbFileNames";
            this.cmbFileNames.Size = new System.Drawing.Size(170, 21);
            this.cmbFileNames.TabIndex = 1;
            this.cmbFileNames.SelectionChangeCommitted += new System.EventHandler(this.cmbFileNames_SelectionChangeCommitted);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::TicTacToe.Properties.Resources.ButtonBg;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPlay.Location = new System.Drawing.Point(554, 297);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(209, 109);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.TabStop = false;
            this.btnPlay.Text = "Jouer";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date :";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::TicTacToe.Properties.Resources.ButtonBg;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnHome.Location = new System.Drawing.Point(554, 390);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(209, 109);
            this.btnHome.TabIndex = 4;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "Revenir à l\'acceuil";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // VAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(829, 523);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.listPlayedGames);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFileNames);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VAR";
            this.Load += new System.EventHandler(this.VideoAssistantReferee_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VAR_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPlayedGames;
        private System.Windows.Forms.ComboBox cmbFileNames;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;

    }
}