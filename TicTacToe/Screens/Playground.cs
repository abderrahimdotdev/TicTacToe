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
    public partial class Playground : Form
    {
        GameManager gameManager;
        Player p1;
        Player p2;
        public Playground()
        {
            InitializeComponent();
        }

        private void Playground_Load(object sender, EventArgs e)
        {
            bool vsPC = this.Tag.ToString() == "1" ? true : false;
            p1 = new Player("Jerry");
            p2 = new Player("Tom");
            gameManager = new GameManager(p1, p2, this.Height, vsPC);
            gameManager.OnNextMove += UpdateUI;
            SetPlayersName();
            HighLightPlayerName();




        }
        private void SetPlayersName()
        {
            Player1Name.Text = p1.Name;
            Player2Name.Text = p2.Name;
        }
        private void RefreshPlayersScore()
        {
            Player1Score.Text = p1.Score.ToString();
            Player2Score.Text = p2.Score.ToString();
        }
        private void UpdateUI(GameProgress progress)
        {
            switch (progress)
            {
                case GameProgress.Over:
                    RefreshPlayersScore();
                    gameManager.NewGame();
                    Repaint();
                    break;
                case GameProgress.Reset:
                    RefreshPlayersScore();
                    Repaint();
                    break;
                case GameProgress.InProgress:

                    break;
                case GameProgress.Draw:
                    gameManager.NewGame();
                    Repaint();
                    break;
            }
            HighLightPlayerName();
        }
        private void HighLightPlayerName()
        {
            Label arrowPlayer1 = lblArrowPlayer1;
            Label arrowPlayer2 = lblArrowPlayer2;
            if (arrowPlayer1.Visible)
            {
                arrowPlayer1.Visible = false;
                arrowPlayer2.Visible = true;
            }
            else
            {
                arrowPlayer1.Visible = true;
                arrowPlayer2.Visible = false;
            }

        }
        private void Playground_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            gameManager.DrawPlayboard(ref g);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            gameManager.NewGame();
            UIManager.ShowHome(this.MdiParent);
            this.Close();
        }

        private void Playground_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            gameManager.MarkMove(e.Location, ref g);

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            gameManager.NewGame(true);
            Repaint();
        }
        private void Repaint()
        {
            Graphics currentGraphics = this.CreateGraphics();
            currentGraphics.Clear(this.BackColor);
            Playground_Paint(null, new PaintEventArgs(currentGraphics, this.ClientRectangle));
        }
    }
}
