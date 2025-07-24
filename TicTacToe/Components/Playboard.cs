using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace TicTacToe.Classes
{
    internal class Playboard
    {
        private static Playboard board;
        private PlayboardField[,] fields;
        private const int Margin = 40;

        private Playboard(int Size)
        {
            fields = new PlayboardField[3, 3];
            int BoardSize = Size - Margin * 2;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    fields[j, i] = new PlayboardField(new Point(i * (BoardSize / 3) + Margin, j * (BoardSize / 3) + Margin), BoardSize / 3);
        }
        public static Playboard CreateBord(int Size)
        {
            if (board == null)
                board = new Playboard(Size);

            return board;
        }

        public string GetCoordinates(PlayboardField field)
        {
            string coordinates = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (fields[i, j] == field)
                    {
                        coordinates = i + "," + j;
                    }
                }
            }
            return coordinates;
        }

        // -- Get a field object (the absolute way) -- 
        public PlayboardField FieldAt(Point p)
        {
            PlayboardField field = null;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (fields[i, j].PointInField(p))
                    {
                        return fields[i, j];
                    }
                }
            }
            return field;
        }

        // -- Get a field object (the relative way) --
        public PlayboardField FieldAt(int x, int y)
        {
            if ((x < 0 || x > 2) || (y < 0 || y > 2)) return null;
            return fields[x, y];
        }
        public int CountEmptySpots()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (fields[i, j].IsEmpty()) count++;
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
                    t = fields[i, j];
                    integerFields[i, j] = t.IsX() ? 1 : (t.IsO() ? -1 : 0);
                }
            }
            return integerFields;
        }

        public void Draw(ref Graphics g)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    fields[i, j].Draw(g);
        }
        public void Clean()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    fields[i, j].Reset();
        }
    }
}
