using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TicTacToe.Screens;

namespace TicTacToe.Classes
{
    internal class UIManager
    {
        public static void ShowHome(Form Container)
        {
            Home home = new Home();
            SetupScreen(Container, home);
            home.Show();
        }
        public static void ShowPlayground(Form Container, int PlayersNumber = 0)
        {
            Playground playground = new Playground();
            playground.Tag = PlayersNumber >= 2 ? 2 : 1;
            SetupScreen(Container, playground);
            playground.Show();
        }
        public static void ShowVAR(Form Container)
        {
            VideoAssistantReferee VAR = new VideoAssistantReferee();
            SetupScreen(Container, VAR);
            VAR.Show();
        }
        private static void SetupScreen(Form container, Form screen)
        {
            Size s = new Size(container.Size.Width - SystemInformation.VerticalScrollBarWidth / 3, container.Size.Height - SystemInformation.HorizontalScrollBarHeight / 3);
            screen.Size = s;
            screen.Location = new Point(0, 0);
            screen.BackColor = GameSettings.DefaultBackgroundColor; ;
            screen.MdiParent = container;
            RenderButtons(screen);
        }
        private static void RenderButtons(Form frm)
        {
            Button btn = null;
            foreach (Control c in frm.Controls)
            {
                if (c.HasChildren)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        btn = (Button)c;
                        RenderButton(btn);
                    }
                }
                if (c is Button)
                {
                    btn = (Button)c;
                    RenderButton(btn);
                }
            }
        }

        private static void RenderButton(Button btn)
        {
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.FlatAppearance.CheckedBackColor = Color.Transparent;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Transparent;
            btn.BackgroundImage = TicTacToe.Properties.Resources.ButtonBg;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
