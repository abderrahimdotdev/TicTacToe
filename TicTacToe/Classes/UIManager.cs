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
            Size s = new Size(Container.Size.Width - SystemInformation.VerticalScrollBarWidth / 3, Container.Size.Height - SystemInformation.HorizontalScrollBarHeight / 3);
            home.Size = s;
            home.Location = new Point(0, 0);
            home.BackColor = GameSettings.DefaultBackgroundColor;
            home.MdiParent = Container;

            RenderButtons(home);
            home.Show();
        }
        public static void ShowPlayground(Form Container, int PlayersNumber = 0)
        {
            Playground playground = new Playground();
            playground.Tag = PlayersNumber >= 2 ? 2 : 1;
            Size s = new Size(Container.Size.Width - SystemInformation.VerticalScrollBarWidth / 3, Container.Size.Height - SystemInformation.HorizontalScrollBarHeight / 3);
            playground.Size = s;
            playground.Location = new Point(0, 0);
            playground.BackColor = GameSettings.DefaultBackgroundColor; ;
            playground.MdiParent = Container;
            RenderButtons(playground);
            playground.Show();
        }
        public static void ShowVAR(Form Container)
        {
            VideoAssistantReferee VAR = new VideoAssistantReferee();
            Size s = new Size(Container.Size.Width - SystemInformation.VerticalScrollBarWidth / 3, Container.Size.Height - SystemInformation.HorizontalScrollBarHeight / 3);
            VAR.Size = s;
            VAR.Location = new Point(0, 0);
            VAR.BackColor = GameSettings.DefaultBackgroundColor; ;
            VAR.MdiParent = Container;
            RenderButtons(VAR);
            VAR.Show();
        }
        public static void PaintPlayboard(object sender, PaintEventArgs e)
        {

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
                        RenderButton(ref btn);
                    }
                }
                if (c is Button)
                {
                    btn = (Button)c;
                    RenderButton(ref btn);
                }

            }
        }
        private static void RenderButton(ref Button btn)
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
