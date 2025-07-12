using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe.Classes
{
    enum GameProgress { Over, InProgress, Draw, Reset }
    internal class GameManager
    {

        Playboard _board;
        Player _player1, _player2;
        Player _currentPlayer;
        bool _startWithTom;
        Log _logger = null;
        GameProgress _progress;
        bool _vsComputer;
        public delegate void Update(GameProgress Progress);
        public event Update OnNextMove;

        public GameManager(Player Player1, Player Player2, int BoardSize, bool VSComputer = false, bool StartWithTom = false)
        {
            _vsComputer = VSComputer;
            _board = Playboard.CreateBord(BoardSize);
            _player1 = Player1;
            _player2 = Player2;
            _logger = new Log(Player1, Player2);
            _currentPlayer = StartWithTom ? Player2 : Player1;
            _startWithTom = StartWithTom;
            _progress = GameProgress.InProgress;

        }

        public void MarkMove(Point p, ref Graphics g, bool LogThis = true)
        {
            PlayboardField currentField = _board.At(p);
            Mark(currentField, ref g, LogThis);
        }
        public void MarkMove(int x, int y, ref Graphics g, bool LogThis = true)
        {
            PlayboardField currentField = _board.At(x, y);
            Mark(currentField, ref g, LogThis);
        }
        private void Mark(PlayboardField f, ref Graphics g, bool LogThis)
        {
            if (f == null) return;

            bool MarkSucceed = (_currentPlayer == _player1 && f.PlayX(ref g) || (_currentPlayer == _player2 && f.PlayO(ref g)));

            if (MarkSucceed)
            {

                if (LogThis) _logger.LogInHistory(_currentPlayer.Name, _board.GetCoordinates(f));
                NextTurn();
                if (_vsComputer && _currentPlayer == _player2)
                {
                    PlayboardField target = PlayAI();
                    System.Threading.Thread.Sleep(500);
                    if (target != null) target.PlayO(ref g);
                    if (LogThis) _logger.LogInHistory(_currentPlayer.Name, _board.GetCoordinates(target));
                    NextTurn();

                }
            }

        }

        private PlayboardField PlayAI()
        {
            PlayboardField t = null;
            int bestScore = -2;

            int[,] fields = _board.ToIntegers();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (fields[i, j] == 0)
                    {
                        fields[i, j] = 1;
                        int score = Minimax(fields, true);
                        fields[i, j] = 0;
                        if (score > bestScore)
                        {
                            bestScore = Math.Max(score, bestScore);
                            t = _board.At(i, j);
                        }
                    }

                }
            }



            return t;


        }
        private int Minimax(int[,] board, bool isMaximizing)
        {
            int winner = CheckWinnerInts(board);
            if (winner != 0) return winner;

            if (isMaximizing)
            {
                int bestScore = -999;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == 0)
                        {

                            board[i, j] = 1;
                            int score = Minimax(board, false);
                            board[i, j] = 0;
                            bestScore = Math.Max(bestScore, score);
                        }
                    }
                }
                return 0;
            }
            else
            {

                int bestScore = 999;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == 0)
                        {
                            board[i, j] = -1;
                            int score = Minimax(board, true);
                            board[i, j] = 0;
                            bestScore = Math.Min(bestScore, score);
                        }
                    }
                }
                return bestScore;

            }

        }
        private int CheckWinnerInts(int[,] fields)
        {


            if (// Diagonally
                (fields[1, 1] == 1 && fields[0, 0] == 1 && fields[2, 2] == 1) ||
                (fields[0, 2] == 1 && fields[2, 0] == 1 && fields[1, 1] == 1) ||
                //Horizontally
                (fields[0, 0] == 1 && fields[0, 1] == 1 && fields[0, 2] == 1) ||
                (fields[1, 0] == 1 && fields[1, 1] == 1 && fields[1, 2] == 1) ||
                (fields[2, 0] == 1 && fields[2, 1] == 1 && fields[2, 2] == 1) ||
                // Verticaaly
                (fields[0, 0] == 1 && fields[1, 0] == 1 && fields[1, 2] == 1) ||
                (fields[0, 1] == 1 && fields[1, 1] == 1 && fields[2, 1] == 1) ||
                (fields[0, 2] == 1 && fields[1, 2] == 1 && fields[2, 2] == 1))
                return 1;

            if (// Diagonally
                (fields[1, 1] == -1 && fields[0, 0] == -1 && fields[2, 2] == -1) ||
                (fields[0, 2] == -1 && fields[2, 0] == -1 && fields[1, 1] == -1) ||
                //Horizontally
                (fields[0, 0] == -1 && fields[0, 1] == -1 && fields[0, 2] == -1) ||
                (fields[1, 0] == -1 && fields[1, 1] == -1 && fields[1, 2] == -1) ||
                (fields[2, 0] == -1 && fields[2, 1] == -1 && fields[2, 2] == -1) ||
                // Verticaaly
                (fields[0, 0] == -1 && fields[1, 0] == -1 && fields[1, 2] == -1) ||
                (fields[0, 1] == -1 && fields[1, 1] == -1 && fields[2, 1] == -1) ||
                (fields[0, 2] == -1 && fields[1, 2] == -1 && fields[2, 2] == -1))
                return -1;

            return 0;

        }
        private void CheckProgress()
        {

            int EmptySpots = _board.CountEmptySpots();
            if (9 - EmptySpots >= 3)
            {
                if (CheckWinner())
                    _progress = GameProgress.Over;
                else if (EmptySpots == 0)
                    _progress = GameProgress.Draw;
            }
            else
                _progress = GameProgress.InProgress;


        }

        private void NextTurn()
        {
            CheckProgress();
            switch (_progress)
            {
                case GameProgress.Over:
                    _currentPlayer.Win();
                    _logger.Save();
                    MessageBox.Show(_currentPlayer.Name + " won the game.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case GameProgress.InProgress:

                    break;
                case GameProgress.Draw:
                    _logger.ClearHistory();
                    MessageBox.Show("Draw.", "No winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            if (OnNextMove != null) OnNextMove(_progress);
            _currentPlayer = _currentPlayer == _player1 ? _player2 : _player1;

        }

        private bool CheckWinner()
        {
            bool Won = false;

            for (int i = 0, j = 2; i < 3 && j >= 0; i++, j--)
            {
                if ((_board.At(1, 1).IsX() && _board.At(0, i).IsX() && _board.At(2, j).IsX()) ||
                    (_board.At(1, 1).IsO() && _board.At(0, i).IsO() && _board.At(2, j).IsO()))
                {
                    Won = true;
                }
                else if ((_board.At(i, 0).IsX() && _board.At(i, 1).IsX() && _board.At(i, 2).IsX()) ||
                        (_board.At(i, 0).IsO() && _board.At(i, 1).IsO() && _board.At(i, 2).IsO()))
                {
                    Won = true;
                }
                else if ((_board.At(0, i).IsX() && _board.At(1, i).IsX() && _board.At(2, i).IsX()) ||
                        (_board.At(0, i).IsO() && _board.At(1, i).IsO() && _board.At(2, i).IsO()))
                {
                    Won = true;
                }
                if (Won) break;
            }
            return Won;
        }
        public void DrawPlayboard(ref Graphics g)
        {
            _board.Draw(ref g);
        }
        public void NewGame(bool ResetScore = false)
        {
            if (ResetScore)
            {
                _player1.ResetScore();
                _player2.ResetScore();
                OnNextMove(GameProgress.Reset);
            }
            _board.Clean();

        }
    }
}
