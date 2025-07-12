using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Classes
{
    internal class GameSettings
    {
        /// <summary>
        /// Gets or sets the directory path where log files are stored.
        /// </summary>
        public static string LogDirectory = String.Concat(Path.GetTempPath(), "TicTacToe\\");

        /// <summary>
        /// Represents the default background color used by the application.
        /// </summary>
        public static Color DefaultBackgroundColor = Color.Cornsilk;

        /// <summary>
        /// Represent image resources of Tom and Jerry used in the application.
        /// </summary>
        public static Image TomPicture = TicTacToe.Properties.Resources.Tom;
        public static Image JerryPicture = TicTacToe.Properties.Resources.Jerry;

        /// <summary>
        /// Represents the default color used for playboard field elements.
        /// </summary>
        public static Color FieldsColor = Color.MidnightBlue;

    }
}
