namespace TicTacToe.Screens
{
    partial class Playground
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
            this.label1 = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.Label();
            this.Player1Name = new System.Windows.Forms.Label();
            this.lblArrowPlayer1 = new System.Windows.Forms.Label();
            this.lblArrowPlayer2 = new System.Windows.Forms.Label();
            this.JerryPic = new System.Windows.Forms.PictureBox();
            this.TomPic = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JerryPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TomPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(617, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score";
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.BackColor = System.Drawing.Color.Transparent;
            this.Player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Player1Score.ForeColor = System.Drawing.Color.Sienna;
            this.Player1Score.Location = new System.Drawing.Point(592, 192);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(39, 42);
            this.Player1Score.TabIndex = 3;
            this.Player1Score.Text = "0";
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.BackColor = System.Drawing.Color.Transparent;
            this.Player2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Player2Score.ForeColor = System.Drawing.Color.SlateGray;
            this.Player2Score.Location = new System.Drawing.Point(690, 192);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(39, 42);
            this.Player2Score.TabIndex = 4;
            this.Player2Score.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // Player2Name
            // 
            this.Player2Name.AutoSize = true;
            this.Player2Name.BackColor = System.Drawing.Color.Transparent;
            this.Player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Name.ForeColor = System.Drawing.Color.SlateGray;
            this.Player2Name.Location = new System.Drawing.Point(689, 245);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(30, 25);
            this.Player2Name.TabIndex = 7;
            this.Player2Name.Text = "...";
            // 
            // Player1Name
            // 
            this.Player1Name.AutoSize = true;
            this.Player1Name.BackColor = System.Drawing.Color.Transparent;
            this.Player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Name.ForeColor = System.Drawing.Color.Sienna;
            this.Player1Name.Location = new System.Drawing.Point(590, 245);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(30, 25);
            this.Player1Name.TabIndex = 8;
            this.Player1Name.Text = "...";
            // 
            // lblArrowPlayer1
            // 
            this.lblArrowPlayer1.AutoSize = true;
            this.lblArrowPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblArrowPlayer1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowPlayer1.ForeColor = System.Drawing.Color.Sienna;
            this.lblArrowPlayer1.Location = new System.Drawing.Point(569, 242);
            this.lblArrowPlayer1.Name = "lblArrowPlayer1";
            this.lblArrowPlayer1.Size = new System.Drawing.Size(29, 29);
            this.lblArrowPlayer1.TabIndex = 9;
            this.lblArrowPlayer1.Text = ">>";
            this.lblArrowPlayer1.Visible = false;
            // 
            // lblArrowPlayer2
            // 
            this.lblArrowPlayer2.AutoSize = true;
            this.lblArrowPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblArrowPlayer2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowPlayer2.ForeColor = System.Drawing.Color.SlateGray;
            this.lblArrowPlayer2.Location = new System.Drawing.Point(668, 242);
            this.lblArrowPlayer2.Name = "lblArrowPlayer2";
            this.lblArrowPlayer2.Size = new System.Drawing.Size(29, 29);
            this.lblArrowPlayer2.TabIndex = 10;
            this.lblArrowPlayer2.Text = ">>";
            this.lblArrowPlayer2.Visible = false;
            // 
            // JerryPic
            // 
            this.JerryPic.Image = global::TicTacToe.Properties.Resources.Jerry;
            this.JerryPic.Location = new System.Drawing.Point(554, 150);
            this.JerryPic.Name = "JerryPic";
            this.JerryPic.Size = new System.Drawing.Size(100, 35);
            this.JerryPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.JerryPic.TabIndex = 12;
            this.JerryPic.TabStop = false;
            // 
            // TomPic
            // 
            this.TomPic.Image = global::TicTacToe.Properties.Resources.Tom;
            this.TomPic.Location = new System.Drawing.Point(673, 150);
            this.TomPic.Name = "TomPic";
            this.TomPic.Size = new System.Drawing.Size(69, 39);
            this.TomPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TomPic.TabIndex = 11;
            this.TomPic.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.BackgroundImage = global::TicTacToe.Properties.Resources.ButtonBg;
            this.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNewGame.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnNewGame.Location = new System.Drawing.Point(554, 296);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(209, 109);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.TabStop = false;
            this.btnNewGame.Text = "Reset scores";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
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
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "Back to home screen";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Playground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(829, 523);
            this.Controls.Add(this.JerryPic);
            this.Controls.Add(this.TomPic);
            this.Controls.Add(this.Player1Name);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblArrowPlayer2);
            this.Controls.Add(this.lblArrowPlayer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Playground";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Playground_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Playground_Paint);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Playground_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.JerryPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TomPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Player2Name;
        private System.Windows.Forms.Label Player1Name;
        private System.Windows.Forms.Label lblArrowPlayer1;
        private System.Windows.Forms.Label lblArrowPlayer2;
        private System.Windows.Forms.PictureBox TomPic;
        private System.Windows.Forms.PictureBox JerryPic;
    }
}

