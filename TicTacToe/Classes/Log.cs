using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.Classes
{
    internal class Log
    {
        List<string> _history;
        Player _player1 = null, _player2 = null;
        int _player1score = 0, _player2score = 0;
        public Log(Player Player1, Player Player2)
        {
            _history = new List<string>();
            _player1 = Player1;
            _player2 = Player2;
        }
        public void LogInHistory(string PlayerName, string PlayedCoordinates)
        {
            _history.Add(PlayerName + " : [" + PlayedCoordinates + "]");

        }

        public void Save()
        {
            if (_history.Count == 0) return;
            string fileName = String.Concat(GameSettings.LogDirectory, FormatLogFileName());
            string[] headLines = FormatHeadline();
            bool fileExists = File.Exists(fileName);
            using (StreamWriter SW = new StreamWriter(fileName, fileExists))
            {

                foreach (string s in headLines)
                {
                    SW.WriteLine(s);
                }
                foreach (string s in _history)
                {
                    SW.WriteLine(s);
                }
                SW.WriteLine("[OVER]");
                SW.Flush();
                SW.Close();
                _history.Clear();
            }

        }
        public static Dictionary<string, string> Import()
        {
            Dictionary<string, string> logFiles = new Dictionary<string, string>();
            string[] logfs = Log.GetFilesPath();
            foreach (string file in logfs)
            {
                logFiles.Add(file, Path.GetFileName(file).Split('.')[0]);
            }
            return logFiles;

        }
        public static void BindTo(ref ComboBox source)
        {
            Dictionary<string, string> logFiles = Import();
            source.DataSource = new BindingSource(logFiles, null);
            source.DisplayMember = "Value";
            source.ValueMember = "Key";
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
            _history.Clear();
        }
        private Player GetWinner()
        {
            Player winner = null;
            int p1score = _player1.GetScore(),
                p2score = _player2.GetScore();
            if (p1score > _player1score && p2score == _player2score)
                winner = _player1;
            else
                winner = _player2;

            _player1score = _player1.GetScore();
            _player2score = _player2.GetScore();

            return winner;
        }
        private string[] FormatHeadline()
        {
            string dashes = "";
            string player1Name = _player1.GetName();
            string player2Name = _player2.GetName();
            if (_player1.GetName() == GetWinner().GetName()) player1Name += " (Winner)"; else player2Name += " (Winner)";

            // In case of any modification to the headline, consider changing the ExtractLabels() method located in VAR Class.
            string headLine = "> " + player1Name + " [" + _player1.GetScore() + "-" + _player2.GetScore() + "] " + player2Name + " :::::: à " + DateTime.Now.ToString();

            foreach (char c in headLine)
            {
                dashes += "-";
            }
            string[] text = { dashes, headLine, dashes };

            return text;
        }
    }
}
