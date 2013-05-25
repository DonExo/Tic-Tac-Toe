using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Runtime.Serialization;
using System.IO;
using System.Media;

namespace Seminarska_TicTacToe
{
    public partial class TicTacToe : Form
    {        
        private List<Button> lstButtons = new List<Button>();
        private string nextChar = "X";
        private Color nextColor;
        private string[,] Matrix = new string[3,3];
        private int clicks, psrToWinGame;
        public string player1 { get; set; }
        public string player2 { get; set; }
        public int Num1, Num2;
        public int TIMER_TIME = 15;
        private float ScoreTie, ScoreP1, ScoreP2, GameNumber;
        private SoundPlayer winningSound = new SoundPlayer(Properties.Resources.Aplause);

        public TicTacToe()
        {
            InitializeComponent();
            initButtons();
            initEverythingElse();
        }

        private void initButtons()
        {
            lstButtons.Add(button0);
            lstButtons.Add(button1);
            lstButtons.Add(button2);
            lstButtons.Add(button3);
            lstButtons.Add(button4);
            lstButtons.Add(button5);
            lstButtons.Add(button6);
            lstButtons.Add(button7);
            lstButtons.Add(button8);

            for (int i = 0; i < 9; ++i)
            {
                lstButtons[i].Click += new EventHandler(btn_click);
                lstButtons[i].Font = new System.Drawing.Font("Segoe Keycaps", 35, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            }

            clicks = 0;
        }

        private void initEverythingElse()
        {
            player1 = XO_Options.str1;
            player2 = XO_Options.str2;
            TIMER_TIME = Num1 = Num2 = XO_Options.timePerRound;
            pBarPlayer1.Maximum = pBarPlayer2.Maximum = TIMER_TIME;
            nextColor = XO_Options.colorP1;
            lblPlayer1.ForeColor = lblPlayer1Score.ForeColor = XO_Options.colorP1;
            lblPlayer2.ForeColor = lblPlayer2Score.ForeColor = XO_Options.colorP2;
            psrToWinGame = XO_Options.pointsToWinGame;

            lblPlayer1Score.Text = string.Format("{0}'s points: 0.0", player1);
            lblPlayer2Score.Text = string.Format("{0}'s points: 0.0", player2);
            lblTieGames.Text = string.Format("Tie Games: 0");
            lblPlayer1.Text = string.Format("{0}'s timeleft: {1} ", player1, TIMER_TIME);
            lblPlayer2.Text = string.Format("{0}'s timeleft: {1}", player2, TIMER_TIME);
            tsGameNumber.Text = string.Format("Game Number #{0}",++GameNumber);
            tsPlayersTurn.Text = string.Format("It's .::{0}'s::. turn!", (nextChar=="X" ? player1 : player2) );
            tsPointsToWinGame.Text = string.Format("Chosen points to win the Game: {0}",psrToWinGame);
          
            ScoreTie = ScoreP1 = ScoreP2 = 0;
            GameNumber = 1;
            pBarPlayer1.Value = pBarPlayer2.Value = TIMER_TIME;
        }

        private void updateLabels()
        {
            lblPlayer1.Text = string.Format("{0}'s timeleft: {1}", player1, pBarPlayer1.Value.ToString());
            lblPlayer2.Text = string.Format("{0}'s timeleft: {1}", player2, pBarPlayer2.Value.ToString());
            lblTieGames.Text = string.Format("Tie Games: {0}", ScoreTie);
            lblPlayer1Score.Text = string.Format("{0}'s points: {1:0.0}", player1, ScoreP1);
            lblPlayer2Score.Text = string.Format("{0}'s points: {1:0.0}", player2, ScoreP2);
            tsGameNumber.Text = string.Format("Game Number #{0}", GameNumber);
            tsPlayersTurn.Text = string.Format("It's .::{0}'s::. turn!", (nextChar == "X" ? player1 : player2));
            tsPointsToWinGame.Text = string.Format("Chosen points to win the Game: {0}",psrToWinGame);

        }

        private bool isWonGame()
        {   // Proverka za krstot i dijagonalite
            if (Matrix[1, 1] == nextChar)
            {
                if ((Matrix[0, 1] == nextChar && Matrix[2, 1] == nextChar) ||
                     (Matrix[1, 0] == nextChar && Matrix[1, 2] == nextChar) ||
                     (Matrix[0, 0] == nextChar && Matrix[2, 2] == nextChar) ||
                     (Matrix[0, 2] == nextChar && Matrix[2, 0] == nextChar))
                    return true;
            }
            // Proverka za Prviot red i Prvata kolona
            else if (Matrix[0, 0] == nextChar)
            {
                if ((Matrix[0, 1] == nextChar && Matrix[0, 2] == nextChar) ||
                    (Matrix[1, 0] == nextChar && Matrix[2, 0] == nextChar))
                    return true;
            }
            // Proverka za Posledniot red i Poslednata kolona
            else if (Matrix[2, 2] == nextChar)
            {
                if ((Matrix[1, 2] == nextChar && Matrix[0, 2] == nextChar) ||
                    (Matrix[2, 0] == nextChar && Matrix[2, 1] == nextChar))
                    return true;
            }

            return false;
        }

        private bool isGameDraw()
        {
            return clicks == 9 || Num1 <= 0 || Num2 <= 0;
        }

        private void resetRound()
        {
            clicks = 0;
            GameNumber++;
            foreach (Button btn in lstButtons)
            {
                btn.Text = "";
                btn.Click -= new EventHandler(btn_click);
                btn.Click += new EventHandler(btn_click);
            }   

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Matrix[i, j] = "";

            pBarPlayer1.Value = pBarPlayer2.Value = Num1 = Num2 = TIMER_TIME;
            updateLabels();
        }

        private void colorChanger()
        {
            if (nextColor == Color.Blue)
                nextColor = Color.Red;
            if (nextColor == Color.Green)
                nextColor = Color.Orange;
            if (nextColor == Color.Purple)
                nextColor = Color.Magenta;
            if (nextColor == Color.Black)
                nextColor = Color.Goldenrod;
        }

        private void colorChangerReverse()
        {
            if (nextColor == Color.Red)
                nextColor = Color.Blue;
            if (nextColor == Color.Orange)
                nextColor = Color.Green;
            if (nextColor == Color.Magenta)
                nextColor = Color.Purple;
            if (nextColor == Color.Goldenrod)
                nextColor = Color.Black;
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = nextColor;
            btn.Text = nextChar;

            switch (btn.Name)
            {
                case "button0":
                    Matrix[0, 0] = nextChar;
                    lstButtons[0].Click -= new EventHandler(btn_click);
                    break;

                case "button1":
                    Matrix[0, 1] = nextChar;
                    lstButtons[1].Click -= new EventHandler(btn_click);
                    break;

                case "button2":
                    Matrix[0, 2] = nextChar;
                    lstButtons[2].Click -= new EventHandler(btn_click);
                    break;

                case "button3":
                    Matrix[1, 0] = nextChar;
                    lstButtons[3].Click -= new EventHandler(btn_click);
                    break;

                case "button4":
                    Matrix[1, 1] = nextChar;
                    lstButtons[4].Click -= new EventHandler(btn_click);
                    break;

                case "button5":
                    Matrix[1, 2] = nextChar;
                    lstButtons[5].Click -= new EventHandler(btn_click);
                    break;

                case "button6":
                    Matrix[2, 0] = nextChar;
                    lstButtons[6].Click -= new EventHandler(btn_click);
                    break;

                case "button7":
                    Matrix[2, 1] = nextChar;
                    lstButtons[7].Click -= new EventHandler(btn_click);
                    break;

                case "button8":
                    Matrix[2, 2] = nextChar;
                    lstButtons[8].Click -= new EventHandler(btn_click);
                    break;
            }

            clicks++;

            if (isWonGame())
            {
                if (nextChar == "X")
                {
                    ScoreP1++;
                    timerPlayer1.Stop();
                    timerPlayer2.Stop();
                    MessageBox.Show("Round Won by: \n .:: " + player1.ToUpper() + " ::.\n +1 point", "We have a WINNER! :)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    updateLabels();
                    if (ScoreP1 >= psrToWinGame)
                    {
                        winningSound.Play();
                        MessageBox.Show(string.Format("\tToday's WINNER is: \n\t -=> {0} <=- \n\t H O O R A Y !!!", player1.ToUpper()), "C O N G R A T Z");
                        if (MessageBox.Show("Do you want to start a new Game?", "Open new game or Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            Application.Restart();
                        else Application.Exit();
                    }
                    resetRound();
                }

                else
                {
                    ScoreP2++;
                    timerPlayer1.Stop();
                    timerPlayer2.Stop();
                    MessageBox.Show(" Round Won by: \n .:: " +  player2.ToUpper() + "::.\n +1 point", "We have a WINNER! :)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    updateLabels();
                    if (ScoreP2 >= psrToWinGame)
                    {
                        winningSound.Play();
                        MessageBox.Show(string.Format("\tToday's WINNER is: \n\t -=> {0} <=- \n\t H O O R A Y !!!",player2.ToUpper()),"C O N G R A T Z");
                        if (MessageBox.Show("Do you want to start a new Game?", "Open new game or Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            Application.Restart();
                        else Application.Exit();
                    }
                    resetRound();
                }
            }
            else if (isGameDraw())
            {
                ScoreTie++;
                timerPlayer1.Stop();
                timerPlayer2.Stop();
                MessageBox.Show("Round Draw! \n No one wins, \n no one loses points." , "No Winner this time :(", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                updateLabels();
                resetRound();
            }

            if (nextChar == "X")
            {
                timerPlayer1.Stop();
                timerPlayer2.Start();
                nextChar = "O";
                colorChanger();
            }
            else
            {
                timerPlayer2.Stop();
                timerPlayer1.Start();
                nextChar = "X";
                colorChangerReverse();
            }

            
        }

        private void timerPlayer1_Tick(object sender, EventArgs e)
        {
            Num1--;
            pBarPlayer1.Value = Num1;
            if (Num1 <= 0)
            {
                ScoreP1 -= 0.5f;
                lblPlayer1.Text = string.Format("{0}'s timeleft: 0", player1);
                timerPlayer1.Stop();
                MessageBox.Show(" Game Draw! \n -0.5 points goes to: \n " +player1.ToUpper() + "\n for timing out.", "Timed out !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetRound();
            }
            updateLabels();
        }

        private void timerPlayer2_Tick(object sender, EventArgs e)
        {
            Num2--;
            pBarPlayer2.Value = Num2;
            if (Num2 <= 0)
            {
                ScoreP2 -= 0.5f;
                lblPlayer2.Text = string.Format("{0}'s timeleft: 0", player2);
                timerPlayer2.Stop();
                MessageBox.Show(" Game Draw! \n -0.5 points goes to: \n " +player2.ToUpper()+ "\n for timing out.", "Timed out !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetRound();
            }
            updateLabels();
           
        }

        private void quitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerPlayer1.Stop();
            timerPlayer2.Stop();
            if (MessageBox.Show("Are you sure you want to quit game?", "Quit Game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
            else {
                if (nextChar == "X") timerPlayer1.Start();
                else timerPlayer2.Start();
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerPlayer1.Stop();
            timerPlayer2.Stop();
            if (MessageBox.Show("Are you sure you want to quit this game?", "Open new game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                if (nextChar == "X") timerPlayer1.Start();
                else timerPlayer2.Start();
            }
        }

        private void tsCopyright_Click(object sender, EventArgs e)
        {
            timerPlayer1.Stop();
            timerPlayer2.Stop();
            if ((MessageBox.Show("1. Доналд Димитриовски - 117007 \n2. Кристина Груевска - 115017 \n3. Дијана Стефановска - 115061 \n\n\n\t ФИНКИ 2012-2013 \n\t Визуелно Програмирање"," C O P Y R I G H T ", MessageBoxButtons.OK) == DialogResult.OK))
            {
                if (nextChar == "X") timerPlayer1.Start();
                else timerPlayer2.Start();
            }

            
        }

        private void blueRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Button btn in lstButtons)
            {
                if (btn.Text == "X") btn.ForeColor = Color.Blue;

                if (btn.Text == "O") btn.ForeColor = Color.Red;

                if (nextChar == "X") nextColor = Color.Blue;
                else nextColor = Color.Red;
            }
            lblPlayer1.ForeColor = lblPlayer1Score.ForeColor = Color.Blue;
            lblPlayer2.ForeColor = lblPlayer2Score.ForeColor = Color.Red;
            blueRedToolStripMenuItem1.Checked = true;
            greenOrangeToolStripMenuItem1.Checked = false;
            purplePinkToolStripMenuItem1.Checked = false;
            blackGoldToolStripMenuItem1.Checked = false;
        }

        private void blackGoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Button btn in lstButtons)
            {
                if (btn.Text == "X") btn.ForeColor = Color.Black;

                if (btn.Text == "O") btn.ForeColor = Color.Goldenrod;

                if (nextChar == "X") nextColor = Color.Black;
                else nextColor = Color.Goldenrod;
            }
            lblPlayer1.ForeColor = lblPlayer1Score.ForeColor = Color.Black;
            lblPlayer2.ForeColor = lblPlayer2Score.ForeColor = Color.Goldenrod;
            blueRedToolStripMenuItem1.Checked = false;
            greenOrangeToolStripMenuItem1.Checked = false;
            purplePinkToolStripMenuItem1.Checked = false;
            blackGoldToolStripMenuItem1.Checked = true;
        }

        private void purplePinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Button btn in lstButtons)
            {
                if (btn.Text == "X") btn.ForeColor = Color.Purple;

                if (btn.Text == "O") btn.ForeColor = Color.Magenta;

                if (nextChar == "X") nextColor = Color.Purple;
                else nextColor = Color.Magenta;
            }
            lblPlayer1.ForeColor = lblPlayer1Score.ForeColor = Color.Purple;
            lblPlayer2.ForeColor = lblPlayer2Score.ForeColor = Color.Magenta;
            blueRedToolStripMenuItem1.Checked = false;
            greenOrangeToolStripMenuItem1.Checked = false;
            purplePinkToolStripMenuItem1.Checked = true;
            blackGoldToolStripMenuItem1.Checked = false;
        }

        private void greenOrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Button btn in lstButtons)
            {
                if (btn.Text == "X") btn.ForeColor = Color.Green;

                if (btn.Text == "O") btn.ForeColor = Color.Orange;

                if (nextChar == "X") nextColor = Color.Green;
                else nextColor = Color.Orange;
            }
            lblPlayer1.ForeColor = lblPlayer1Score.ForeColor = Color.Green;
            lblPlayer2.ForeColor = lblPlayer2Score.ForeColor = Color.Orange;
            blueRedToolStripMenuItem1.Checked = false;
            greenOrangeToolStripMenuItem1.Checked = true;
            purplePinkToolStripMenuItem1.Checked = false;
            blackGoldToolStripMenuItem1.Checked = false;
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerPlayer1.Stop();
            timerPlayer2.Stop();
            if (MessageBox.Show(string.Format("Win the round by having 3 X's or O's \nhorizontally, vertically or diagonically."), "How to Play?", MessageBoxButtons.OK) == DialogResult.OK)
            {
                if (nextChar == "X") timerPlayer1.Start();
                else timerPlayer2.Start();
            }
            else
            {
                if (nextChar == "X") timerPlayer1.Start();
                else timerPlayer2.Start();
            }

        }

    }
}