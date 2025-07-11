using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Classes
{
    internal class Player
    {
        int _score;
        string _name;

        public Player(string PlayerName)
        {
            if (string.IsNullOrWhiteSpace(PlayerName.Trim())) throw new ArgumentNullException("PlayerName", "All players must have a name");
            _name = PlayerName;
            _score = 0;
        }
        public void Win()
        {
            _score++;
        }
        public void ResetScore()
        {
            _score = 0;
        }
        public string GetName()
        {
            return _name;
        }

        public int GetScore()
        {
            return _score;
        }
    }
}
