using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminarska_TicTacToe
{
    public partial class XO_Options : Form
    {
        private ErrorProvider err = new ErrorProvider();
        private bool Exiting = true;
        public static string str1, str2;
        public static int timePerRound, pointsToWinGame;
        public static Color colorP1, colorP2;

        public XO_Options()
        {
            InitializeComponent();
            cbColors.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (tbPlayer1.Text.Trim().Length > 0 && tbPlayer1.Text.Trim().Length <= 10 && tbPlayer2.Text.Trim().Length > 0 && tbPlayer2.Text.Trim().Length <= 10)
            {
                str1 = tbPlayer1.Text.Trim();
                str2 = tbPlayer2.Text.Trim();
                timePerRound = (int)numTimePerRound.Value;
                pointsToWinGame = (int)numRoundsForWin.Value;
                Exiting = false;
                this.Close();
            }
            else return;
            
        }

        private void cbColors_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbColors.SelectedIndex != -1) {
                switch (cbColors.SelectedIndex)
                {
                    case 0:
                        colorP1 = Color.Blue;
                        colorP2 = Color.Red;
                        break;

                    case 1:
                        colorP1 = Color.Green;
                        colorP2 = Color.Orange;
                        break;

                    case 2:
                        colorP1 = Color.Purple;
                        colorP2 = Color.Magenta;
                        break;

                    case 3:
                        colorP1 = Color.Black;
                        colorP2 = Color.Goldenrod;
                        break;
                }
           }


        }

        private void tbPlayer1_Validating(object sender, CancelEventArgs e)
        {
            if (tbPlayer1.Text.Trim().Length > 10 || tbPlayer1.Text.Trim().Length <= 0)
            {
                e.Cancel = true;
                err.SetError(tbPlayer1, "Please enter string from 1 to 10 characters !\n\nOr if You want to leave the game \nclick the \"Exit Game\" button.");
            }
            else err.SetError(tbPlayer1, "");

        }

        private void tbPlayer2_Validating(object sender, CancelEventArgs e)
        {
            if (tbPlayer2.Text.Trim().Length > 10 || tbPlayer2.Text.Trim().Length <= 0)
            {
                e.Cancel = true;
                err.SetError(tbPlayer2, "Please enter string from 1 to 10 characters !\n\nOr if You want to leave the game \nclick the \"Exit Game\" button.");
            }
            else err.SetError(tbPlayer2, "");
        }

        private void XO_Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Exiting)
            {
                Application.Exit();
            }
            
          
        }

    }
}
