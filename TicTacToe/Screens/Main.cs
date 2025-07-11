using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            UIManager.ShowHome(this);
        }

        private void Main_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
