using System;
using System.Media;
using System.Windows.Forms;
using TicTacToe.Classes;

namespace TicTacToe.Screens
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SoundPlayer bgMusic = new SoundPlayer(TicTacToe.Properties.Resources.Tom_And_Jerry_Main_Theme);
            bgMusic.PlayLooping();
            UIManager.ShowHome(this);
        }

        private void Main_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
