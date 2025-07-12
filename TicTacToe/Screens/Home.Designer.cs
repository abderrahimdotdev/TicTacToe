namespace TicTacToe.Screens
{
    partial class Home
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
            this.labelCopy = new System.Windows.Forms.Label();
            this.lblFullscreen = new System.Windows.Forms.LinkLabel();
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnVar = new System.Windows.Forms.Button();
            this.btnPlay2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCopy
            // 
            this.labelCopy.AutoSize = true;
            this.labelCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopy.Location = new System.Drawing.Point(1373, 913);
            this.labelCopy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(222, 29);
            this.labelCopy.TabIndex = 6;
            this.labelCopy.Text = "© Abderrahim 2020";
            // 
            // lblFullscreen
            // 
            this.lblFullscreen.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblFullscreen.AutoSize = true;
            this.lblFullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullscreen.LinkColor = System.Drawing.Color.Black;
            this.lblFullscreen.Location = new System.Drawing.Point(76, 913);
            this.lblFullscreen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFullscreen.Name = "lblFullscreen";
            this.lblFullscreen.Size = new System.Drawing.Size(275, 29);
            this.lblFullscreen.TabIndex = 8;
            this.lblFullscreen.TabStop = true;
            this.lblFullscreen.Text = "Enable full-screen mode";
            this.lblFullscreen.VisitedLinkColor = System.Drawing.Color.Black;
            this.lblFullscreen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFullscreen_LinkClicked);
            // 
            // btnPlay1
            // 
            this.btnPlay1.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay1.BackgroundImage = global::TicTacToe.Properties.Resources.ButtonBg;
            this.btnPlay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPlay1.FlatAppearance.BorderSize = 0;
            this.btnPlay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPlay1.Location = new System.Drawing.Point(1188, 90);
            this.btnPlay1.Margin = new System.Windows.Forms.Padding(6);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(418, 210);
            this.btnPlay1.TabIndex = 9;
            this.btnPlay1.TabStop = false;
            this.btnPlay1.Text = "1 VS PC";
            this.btnPlay1.UseVisualStyleBackColor = false;
            this.btnPlay1.Click += new System.EventHandler(this.btnPlay1_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = global::TicTacToe.Properties.Resources.ButtonBg;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnQuit.Location = new System.Drawing.Point(1180, 631);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(6);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(418, 210);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnVar
            // 
            this.btnVar.BackColor = System.Drawing.Color.Transparent;
            this.btnVar.BackgroundImage = global::TicTacToe.Properties.Resources.ButtonBg;
            this.btnVar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVar.FlatAppearance.BorderSize = 0;
            this.btnVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnVar.Location = new System.Drawing.Point(1180, 452);
            this.btnVar.Margin = new System.Windows.Forms.Padding(6);
            this.btnVar.Name = "btnVar";
            this.btnVar.Size = new System.Drawing.Size(418, 210);
            this.btnVar.TabIndex = 3;
            this.btnVar.TabStop = false;
            this.btnVar.Text = "VAR";
            this.btnVar.UseVisualStyleBackColor = false;
            this.btnVar.Click += new System.EventHandler(this.btnVar_Click);
            // 
            // btnPlay2
            // 
            this.btnPlay2.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay2.BackgroundImage = global::TicTacToe.Properties.Resources.ButtonBg;
            this.btnPlay2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPlay2.FlatAppearance.BorderSize = 0;
            this.btnPlay2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPlay2.Location = new System.Drawing.Point(1180, 271);
            this.btnPlay2.Margin = new System.Windows.Forms.Padding(6);
            this.btnPlay2.Name = "btnPlay2";
            this.btnPlay2.Size = new System.Drawing.Size(418, 210);
            this.btnPlay2.TabIndex = 2;
            this.btnPlay2.TabStop = false;
            this.btnPlay2.Text = "2 Players";
            this.btnPlay2.UseVisualStyleBackColor = false;
            this.btnPlay2.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicTacToe.Properties.Resources.Background;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(82, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1010, 673);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1658, 1006);
            this.Controls.Add(this.btnPlay1);
            this.Controls.Add(this.lblFullscreen);
            this.Controls.Add(this.labelCopy);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnVar);
            this.Controls.Add(this.btnPlay2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay2;
        private System.Windows.Forms.Button btnVar;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label labelCopy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblFullscreen;
        private System.Windows.Forms.Button btnPlay1;
    }
}