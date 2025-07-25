﻿using System;
using System.Drawing;
using System.IO;

namespace TicTacToe.Classes
{
    internal class GameSettings
    {
        /// <summary>
        /// Gets or sets the directory path where log files are stored.
        /// </summary>
        public static readonly string LogDirectory = AppContext.BaseDirectory;

        /// <summary>
        /// Represents the default background color used by the application.
        /// </summary>
        public static readonly Color DefaultBackgroundColor = Color.Cornsilk;

        /// <summary>
        /// Represent image resources of Tom and Jerry used in the application.
        /// </summary>
        public static readonly Image TomPicture = TicTacToe.Properties.Resources.Tom;
        public static readonly Image JerryPicture = TicTacToe.Properties.Resources.Jerry;

        /// <summary>
        /// Represents the default color used for playboard field elements.
        /// </summary>
        public static readonly Color FieldsColor = Color.MidnightBlue;
    }
}
