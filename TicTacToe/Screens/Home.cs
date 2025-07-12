using System;
using System.Drawing;
using System.Windows.Forms;
using TicTacToe.Classes;

namespace TicTacToe.Screens
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            UIManager.ShowPlayground(this.MdiParent, 2);
            this.Close();
        }

        private void btnVar_Click(object sender, EventArgs e)
        {
            UIManager.ShowVAR(this.MdiParent);
            this.Close();
        }

        private void lblFullscreen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void ChangeScreenMode(LinkLabel sender)
        {
            if (sender.LinkColor == Color.Black)
            {
                this.MdiParent.WindowState = FormWindowState.Maximized;
                sender.Text = "Quit full-screen mode";
                sender.ForeColor = sender.ActiveLinkColor = sender.VisitedLinkColor = sender.LinkColor = Color.Red;
            }
            else
            {
                this.MdiParent.WindowState = FormWindowState.Normal;
                sender.Text = "Enable full-screen mode";
                sender.ForeColor = sender.ActiveLinkColor = sender.VisitedLinkColor = sender.LinkColor = Color.Black;
            }


        }

        private void btnPlay1_Click(object sender, EventArgs e)
        {
            UIManager.ShowPlayground(this.MdiParent, 1);
            this.Close();
        }
    }
}
