using System;
using System.Drawing;
using System.Windows.Forms;

namespace Seminarska_TicTacToe
{
    public partial class SplashScreen : Form
    {
        Timer t = new Timer();
        bool fadeIn = true;
        bool fadeOut = false;

        public SplashScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Opacity = 0.4;
            this.BackgroundImage = Seminarska_TicTacToe.Properties.Resources.logo;
            setAndStartTimer();
        }

        private void setAndStartTimer()
        {
            t.Interval = 70;
            t.Tick += new EventHandler(t_tick);
            t.Start();
        }

        private void t_tick(object sender, EventArgs e)
        {
          if (fadeIn)
            {
                if (this.Opacity < 1.0)
                {
                    this.Opacity += 0.02;
                }
             
                else
                {
                    fadeIn = false;
                    fadeOut = true;
                }
            }
            else if (fadeOut) 
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.02;
                }
                else
                {
                    fadeOut = false;
                }
            }

            if (!(fadeIn || fadeOut))
            {
                t.Stop();
                this.Close();
            }
        }
    }
}
