using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Classes
{
    internal class Playboard
    {
        static PlayboardField[,] _fields;
        static Playboard _board;


        private Playboard(int Size)
        {
            _fields = new PlayboardField[3, 3];
            int Margin = 40;
            int BoardSize = Size - Margin * 2;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    _fields[j, i] = new PlayboardField(new Point(i * (BoardSize / 3) + Margin, j * (BoardSize / 3) + Margin), BoardSize / 3);
        }
        public static Playboard CreateBord(int Size)
        {
            if (_board == null)
                _board = new Playboard(Size);

            return _board;
        }

        public string GetCoordinates(PlayboardField field)
        {
            string coordinates = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_fields[i, j] == field)
                    {
                        coordinates = i + "," + j;
                    }
                }
            }
            return coordinates;
        }

        // -- Get a field object (the absolute way) -- 
        public PlayboardField At(Point p)
        {
            PlayboardField field = null;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_fields[i, j].PointInField(p))
                    {
                        return _fields[i, j];
                    }
                }
            }
            return field;
        }

        // -- Get a field object (the relative way) --
        public PlayboardField At(int x, int y)
        {
            if ((x < 0 || x > 2) || (y < 0 || y > 2)) return null;
            return _fields[x, y];
        }
        public int CountEmptySpots()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_fields[i, j].IsEmpty()) count++;
                }
            }

            return count;
        }
        public int[,] ToIntegers()
        {

            int[,] integerFields = new int[3, 3];
            PlayboardField t;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    t = _fields[i, j];
                    integerFields[i, j] = t.IsX() ? 1 : (t.IsO() ? -1 : 0);
                }
            }

            return integerFields;

        }

        public void Clean()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    _fields[i, j].Reset();
        }
    }
}
