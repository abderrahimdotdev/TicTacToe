using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace TicTacToe.Classes
{
    enum State { Empty = 0, X = 1, O = -1 };
    internal class PlayboardField
    {
        Rectangle _rectangle;
        State _currentState;
        Image _image1 = null, _image2 = null;
        static readonly int _imageMargin = 25;
        public PlayboardField(Point Location, int Size)
        {
            _rectangle = new Rectangle(Location, new Size(Size, Size));
            _currentState = State.Empty;

        }

        public bool PointInField(Point p)
        {
            return _rectangle.Contains(p);
        }
        public bool IsEmpty()
        {
            return _currentState == State.Empty;
        }
        public void Reset()
        {
            _currentState = State.Empty;
        }
        public bool PlayX(ref Graphics g)
        {
            if (IsEmpty())
            {
                if (_image1 != null)
                {
                    Image newImage = _image1;
                    Point corner = new Point(_rectangle.Left + _imageMargin / 2, _rectangle.Top + _imageMargin / 2);
                    g.DrawImage(newImage, corner);
                }
                else
                    DrawX(ref g);
                _currentState = State.X;
                return true;
            }
            return false;
        }
        public bool PlayO(ref Graphics g)
        {
            if (IsEmpty())
            {

                if (_image2 != null)
                {
                    Image newImage = _image2;
                    Point corner = new Point(_rectangle.Left + _imageMargin / 2, _rectangle.Top + _imageMargin / 2);
                    g.DrawImage(newImage, corner);
                }
                else
                    DrawO(ref g);
                _currentState = State.O;
                return true;
            }
            return false;
        }

        // -- Fallback Methods --
        private void DrawX(ref Graphics g)
        {
            int Padding = 20;
            Pen p = new Pen(Color.Brown, 15);
            int Left = _rectangle.Left + Padding,
                Right = _rectangle.Right - Padding,
                Top = _rectangle.Top + Padding,
                Bottom = _rectangle.Bottom - Padding;
            g.DrawLine(p, Left, Top, Right, Bottom);
            g.DrawLine(p, Right, Top, Left, Bottom);
        }
        private void DrawO(ref Graphics g)
        {
            Brush b = new SolidBrush(Color.DarkBlue);
            int Padding = 20;
            g.FillEllipse(b, _rectangle.Left + Padding / 2, _rectangle.Top + Padding / 2, _rectangle.Width - Padding, _rectangle.Width - Padding);
        }

        public bool IsO()
        {
            return _currentState == State.O;
        }
        public bool IsX()
        {
            return _currentState == State.X;
        }
    }
}
