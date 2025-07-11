using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Classes
{
    internal class GameSettings
    {
        public static string LogDirectory = @"";
        public static Color DefaultBackgroundColor = Color.Cornsilk;
        public static Image TomPicture = TicTacToe.Properties.Resources.Tom;
        public static Color FieldsColor = Color.MidnightBlue;
        public static Image JerryPicture = TicTacToe.Properties.Resources.Jerry;
    }
}
