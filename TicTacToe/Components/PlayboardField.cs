using System;
using System.Drawing;

namespace TicTacToe.Classes
{

    internal class PlayboardField
    {

        enum State { Empty = 0, X = 1, O = -1 };


        private Rectangle rectangle;
        private State currentState;
        private Image jerry, tom;

        /// <summary>
        /// Margin used for drawing tom and jerry images in the playboard field.
        /// </summary>
        const int margin = 25;

        public PlayboardField(Point Location, int Size)
        {
            rectangle = new Rectangle(Location, new Size(Size, Size));
            currentState = State.Empty;
            jerry = GameSettings.JerryPicture.GetThumbnailImage(rectangle.Width - margin, rectangle.Height - margin, null, new IntPtr());
            tom = GameSettings.TomPicture.GetThumbnailImage(rectangle.Width - margin, rectangle.Height - margin, null, new IntPtr());

        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(GameSettings.FieldsColor, 2);
            g.DrawRectangle(p, rectangle);

        }
        public bool PlayX(ref Graphics g)
        {
            if (!IsEmpty()) return false;

            if (jerry != null) drawImage(ref g, jerry);
            else DrawX(ref g);

            currentState = State.X;
            return true;

        }
        public bool PlayO(ref Graphics g)
        {
            if (!IsEmpty()) return false;

            if (tom != null) drawImage(ref g, tom);
            else DrawO(ref g);

            currentState = State.O;
            return true;
        }

        // -- Fallback Methods --
        private void DrawX(ref Graphics g)
        {
            int Padding = 20;
            Pen p = new Pen(Color.Brown, 15);
            int Left = rectangle.Left + Padding,
                Right = rectangle.Right - Padding,
                Top = rectangle.Top + Padding,
                Bottom = rectangle.Bottom - Padding;
            g.DrawLine(p, Left, Top, Right, Bottom);
            g.DrawLine(p, Right, Top, Left, Bottom);
        }
        private void DrawO(ref Graphics g)
        {
            Brush b = new SolidBrush(Color.DarkBlue);
            int Padding = 20;
            g.FillEllipse(b, rectangle.Left + Padding / 2, rectangle.Top + Padding / 2, rectangle.Width - Padding, rectangle.Width - Padding);
        }


        // -- Utility Methods --

        public bool PointInField(Point p)
        {
            return rectangle.Contains(p);
        }
        public bool IsEmpty()
        {
            return currentState == State.Empty;
        }
        public bool IsO()
        {
            return currentState == State.O;
        }
        public bool IsX()
        {
            return currentState == State.X;
        }
        public void Reset()
        {
            currentState = State.Empty;
        }
        private void drawImage(ref Graphics g, Image img)
        {
            Point corner = new Point(rectangle.Left + margin / 2, rectangle.Top + margin / 2);
            g.DrawImage(img, corner);
        }
    }
}
