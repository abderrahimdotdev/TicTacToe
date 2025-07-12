using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TicTacToe.Classes;

namespace TicTacToe.Screens
{
    public partial class VideoAssistantReferee : Form
    {

        Dictionary<string, string> logFiles = null;
        Dictionary<int, Dictionary<string, List<string>>> GameSteps;
        Dictionary<int, string> StartingPlayers = null;
        GameManager gm;
        string player1Name = "", player2Name = "";
        BackgroundWorker BW;
        public VideoAssistantReferee()
        {
            InitializeComponent();
        }

        private void VideoAssistantReferee_Load(object sender, EventArgs e)
        {

            logFiles = Log.Import();
            Log.BindTo(ref cmbFileNames);
            GameSteps = new Dictionary<int, Dictionary<string, List<string>>>();
            StartingPlayers = new Dictionary<int, string>();
            gm = new GameManager(new Player("Tom"), new Player("Jerry"), this.Height);
            cmbFileNames_SelectionChangeCommitted(cmbFileNames, null);
            BW = new BackgroundWorker();
            BW.DoWork += PlayGame;
            BW.WorkerSupportsCancellation = true;
            BW.RunWorkerCompleted += Done;


        }

        private void PlayGame(object sender, DoWorkEventArgs e)
        {

            int selectedIndex = (int)e.Argument;
            string p1 = StartingPlayers[selectedIndex];
            string p2 = (p1 == player1Name) ? player2Name : player1Name;
            string lastPlayed = p1;
            gm = new GameManager(new Player(p1), new Player(p2), this.Height, p1.ToLower() == "tom" ? true : false);


            int step = 0;

            while (step < GameSteps[selectedIndex][lastPlayed].Count)
            {
                System.Threading.Thread.Sleep(1000);
                if (BW.CancellationPending)
                {
                    if (BW.CancellationPending) CancelBackgroundWork();
                    return;
                }
                SimulateMove(selectedIndex, lastPlayed, step);
                if (lastPlayed == p1)
                    lastPlayed = p2;
                else
                {
                    lastPlayed = p1;
                    step++; // Incrementing the step counter after both of players are made their coresponding steps
                }
            }

        }
        private void CancelBackgroundWork()
        {
            gm.NewGame();
            BW.DoWork -= PlayGame;
            BW.RunWorkerCompleted -= Done;



        }
        private void Done(object sender, RunWorkerCompletedEventArgs e)
        {
            if (BW.CancellationPending) CancelBackgroundWork();
            if (MessageBox.Show("Play again ?", "Replay another game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                BW.RunWorkerAsync(listPlayedGames.SelectedIndex);
            Repaint();
            gm.NewGame();

        }

        private void SimulateMove(int GameIndex, string playerName, int stepNumber)
        {

            string cords = GameSteps[GameIndex][playerName][stepNumber];
            Graphics g = this.CreateGraphics();
            gm.MarkMove(int.Parse(cords.Split(',')[0]), int.Parse(cords.Split(',')[1]), ref g, false);

        }


        private void LoadLogData(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName) || GameSteps.Count > 0)
            {
                GameSteps.Clear();
                StartingPlayers.Clear();
            }

            if (logFiles.ContainsKey(fileName))
            {
                string title = "";
                int index = 0;
                listPlayedGames.Items.Clear();
                string line;
                //List<string> Files = new List<string>();
                using (StreamReader SR = new StreamReader(fileName))
                {
                    while ((line = SR.ReadLine()) != null)
                    {
                        if (line[0] == '>')
                        {
                            title = Log.ShortHeadline(line);
                            listPlayedGames.Items.Add(title);
                            //Files.Add(title);
                            GameSteps.Add(index, new Dictionary<string, List<string>>());
                            player1Name = title.Split(' ')[0].Trim();
                            player2Name = title.Split(']')[1].Trim().Split(' ')[0].Trim();
                            GameSteps[index].Add(player1Name, new List<string>());
                            GameSteps[index].Add(player2Name, new List<string>());

                        }
                        else
                        {
                            if (line[0] != '-' && !line.ToLower().Contains("over"))
                            {
                                string key = line.Split(' ')[0].Trim();
                                string steps = line.Split('[')[1].Trim().Split(']')[0].Trim();

                                if (!StartingPlayers.ContainsKey(index)) StartingPlayers.Add(index, key);
                                GameSteps[index][key].Add(steps);
                            }
                            if (line.ToLower().Contains("over"))
                            {
                                index++;
                            }
                        }

                    }
                }
            }
        }


        private void VAR_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            gm.DrawPlayboard(ref g);
        }
        private void Repaint()
        {

            Graphics currentGraphics = this.CreateGraphics();
            currentGraphics.Clear(this.BackColor);
            VAR_Paint(null, new PaintEventArgs(currentGraphics, this.ClientRectangle));


        }

        private void cmbFileNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadLogData(((ComboBox)sender).SelectedValue.ToString());

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (listPlayedGames.SelectedIndex >= 0)
            {
                if (!BW.IsBusy)
                {
                    BW.RunWorkerAsync(listPlayedGames.SelectedIndex);
                }
            }
            else
                MessageBox.Show("Please select the game to replay.", "Invalid choice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            BW.CancelAsync();
            UIManager.ShowHome(this.MdiParent);
            this.Close();
        }
    }
}
