using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TicTacToe.Classes
{
    enum GameProgress { Over, InProgress, Draw, Reset }
    internal class GameManager
    {

        private Playboard board;
        private Player player1, player2;
        private Player currentPlayer;
        private readonly bool startWithTom;
        private GameLogger logger = null;
        private GameProgress progress;
        private bool vsComputer;

        public delegate void Update(GameProgress Progress);
        public event Update OnNextMove;

        public GameManager(Player Player1, Player Player2, int BoardSize, bool VSComputer = false, bool StartWithTom = false)
        {
            vsComputer = VSComputer;
            board = Playboard.CreateBord(BoardSize);
            player1 = Player1;
            player2 = Player2;
            logger = new GameLogger(Player1, Player2);
            currentPlayer = StartWithTom ? Player2 : Player1;
            startWithTom = StartWithTom;
            progress = GameProgress.InProgress;

        }

        public void MarkMove(Point p, ref Graphics g, bool LogThis = true)
        {
            PlayboardField currentField = board.FieldAt(p);
            Mark(currentField, ref g, LogThis);
        }
        public void MarkMove(int x, int y, ref Graphics g, bool LogThis = true)
        {
            PlayboardField currentField = board.FieldAt(x, y);
            Mark(currentField, ref g, LogThis);
        }
        private void Mark(PlayboardField f, ref Graphics g, bool LogThis)
        {
            if (f == null) return;

            bool MarkSucceed = (currentPlayer == player1 && f.PlayX(ref g) || (currentPlayer == player2 && f.PlayO(ref g)));

            if (MarkSucceed)
            {
                if (LogThis) logger.LogInHistory(currentPlayer.Name, board.GetCoordinates(f));
                NextTurn();
                if (vsComputer && currentPlayer == player2)
                {
                    PlayboardField target = PlayAI();
                    System.Threading.Thread.Sleep(new Random().Next(300,800));
                    if (target != null) target.PlayO(ref g);
                    if (LogThis) logger.LogInHistory(currentPlayer.Name, board.GetCoordinates(target));
                    NextTurn();

                }
            }

        }

        private PlayboardField PlayAI()
        {
            PlayboardField t = null;

            if (board.CountEmptySpots() >= 8)
            {
                Random r = new Random();
                t = board.FieldAt(r.Next(0,3), r.Next(0, 3));
                return t;
            }
            
            int bestScore = -2;
            int[,] fields = board.ToIntegers();

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
                            t = board.FieldAt(i, j);
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
            int EmptySpots = board.CountEmptySpots();
            if (9 - EmptySpots >= 3)
            {
                if (CheckWinner())
                    progress = GameProgress.Over;
                else if (EmptySpots == 0)
                    progress = GameProgress.Draw;
            }
            else
                progress = GameProgress.InProgress;
        }

        private void NextTurn()
        {
            CheckProgress();
            if(progress == GameProgress.Over)
            {
                currentPlayer.Win();
                logger.Save();
                MessageBox.Show(currentPlayer.Name + " won the game.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);   
            }
            else if (progress == GameProgress.Draw)
            {
                logger.ClearHistory();
                MessageBox.Show("Draw.", "No winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (OnNextMove != null) OnNextMove(progress);
            currentPlayer = currentPlayer == player1 ? player2 : player1;

        }

        private bool CheckWinner()
        {
            bool Won = false;

            for (int i = 0, j = 2; i < 3 && j >= 0; i++, j--)
            {
                if ((board.FieldAt(1, 1).IsX() && board.FieldAt(0, i).IsX() && board.FieldAt(2, j).IsX()) ||
                    (board.FieldAt(1, 1).IsO() && board.FieldAt(0, i).IsO() && board.FieldAt(2, j).IsO()))
                {
                    Won = true;
                }
                else if ((board.FieldAt(i, 0).IsX() && board.FieldAt(i, 1).IsX() && board.FieldAt(i, 2).IsX()) ||
                        (board.FieldAt(i, 0).IsO() && board.FieldAt(i, 1).IsO() && board.FieldAt(i, 2).IsO()))
                {
                    Won = true;
                }
                else if ((board.FieldAt(0, i).IsX() && board.FieldAt(1, i).IsX() && board.FieldAt(2, i).IsX()) ||
                        (board.FieldAt(0, i).IsO() && board.FieldAt(1, i).IsO() && board.FieldAt(2, i).IsO()))
                {
                    Won = true;
                }
                if (Won) break;
            }
            return Won;
        }
        public void DrawPlayboard(ref Graphics g)
        {
            board.Draw(ref g);
        }
        public void NewGame(bool ResetScore = false)
        {
            if (ResetScore)
            {
                player1.ResetScore();
                player2.ResetScore();
                OnNextMove(GameProgress.Reset);
            }
            board.Clean();

        }
    }
}
