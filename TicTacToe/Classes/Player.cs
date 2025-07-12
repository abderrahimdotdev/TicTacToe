using System;

namespace TicTacToe.Classes
{
    internal class Player
    {
        public int Score { get; private set; }
        public string Name { get; private set; }

        public Player(string PlayerName)
        {
            if (string.IsNullOrWhiteSpace(PlayerName.Trim())) throw new ArgumentNullException("PlayerName", "All players must have a name");
            Name = PlayerName;
            Score = 0;
        }
        public void Win()
        {
            Score++;
        }
        public void ResetScore()
        {
            Score = 0;
        }

    }
}
