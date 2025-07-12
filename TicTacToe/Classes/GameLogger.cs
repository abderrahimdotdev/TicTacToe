using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TicTacToe.Classes
{
    internal class GameLogger
    {
        private List<string> history;
        private Player player1 = null, player2 = null;
        private int player1score = 0, player2score = 0;
        public GameLogger(Player Player1, Player Player2)
        {
            history = new List<string>();
            player1 = Player1;
            player2 = Player2;
        }
        public void LogInHistory(string PlayerName, string PlayedCoordinates)
        {
            history.Add(PlayerName + " : [" + PlayedCoordinates + "]");

        }

        public void Save()
        {
            if (history.Count == 0) return;
            if (!Directory.Exists(GameSettings.LogDirectory))
            {
                Directory.CreateDirectory(GameSettings.LogDirectory);
            }
            string logFile = Path.Combine(GameSettings.LogDirectory, FormatLogFileName());


            string[] headLines = FormatHeadline();
            bool fileExists = File.Exists(logFile);
            using (StreamWriter SW = new StreamWriter(logFile, fileExists))
            {

                foreach (string s in headLines)
                {
                    SW.WriteLine(s);
                }
                foreach (string s in history)
                {
                    SW.WriteLine(s);
                }
                SW.WriteLine("[OVER]");
                SW.Flush();
                SW.Close();
                history.Clear();
            }

        }
        public static Dictionary<string, string> Import()
        {
            Dictionary<string, string> logFiles = new Dictionary<string, string>();
            string[] logfs = GameLogger.GetFilesPath();
            foreach (string file in logfs)
            {
                logFiles.Add(file, Path.GetFileName(file).Split('.')[0]);
            }
            return logFiles;

        }
        public static string[] GetFilesPath()
        {
            return Directory.GetFiles(GameSettings.LogDirectory, "*.txt");
        }
        private string FormatLogFileName()
        {
            return String.Concat(DateTime.Now.ToShortDateString().Replace(' ', '_').Replace(':', '-').Replace('/', '-').Trim(), ".txt");
        }
        public static string ShortHeadline(string headline)
        {
            return headline.Substring(headline.IndexOf(' ') + 1, headline.IndexOf(':') - 2).Trim();
        }
        public void ClearHistory()
        {
            history.Clear();
        }
        private Player GetWinner()
        {
            Player winner = null;
            int p1score = player1.Score,
                p2score = player2.Score;
            if (p1score > player1score && p2score == player2score)
                winner = player1;
            else
                winner = player2;

            player1score = player1.Score;
            player2score = player2.Score;

            return winner;
        }
        private string[] FormatHeadline()
        {
            string dashes = "";
            string player1Name = player1.Name;
            string player2Name = player2.Name;
            if (player1.Name == GetWinner().Name) player1Name += " (Winner)"; else player2Name += " (Winner)";

            // In case of any modification to the headline, consider changing the ExtractLabels() method located in VAR Class.
            string headLine = "> " + player1Name + " [" + player1.Score + "-" + player2.Score + "] " + player2Name + " :::::: à " + DateTime.Now.ToString();

            foreach (char c in headLine)
            {
                dashes += "-";
            }
            string[] text = { dashes, headLine, dashes };

            return text;
        }
    }
}
