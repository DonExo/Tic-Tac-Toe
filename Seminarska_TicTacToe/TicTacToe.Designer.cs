namespace Seminarska_TicTacToe
{
    partial class TicTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.pBarPlayer1 = new System.Windows.Forms.ProgressBar();
            this.pBarPlayer2 = new System.Windows.Forms.ProgressBar();
            this.timerPlayer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTieGames = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.timerPlayer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsGameNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPlayersTurn = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPointsToWinGame = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pickColorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueRedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenOrangeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.purplePinkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blackGoldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameOptionsToolStripMenuItem
            // 
            this.gameOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.pickColorsToolStripMenuItem1,
            this.toolStripSeparator2,
            this.howToPlayToolStripMenuItem});
            this.gameOptionsToolStripMenuItem.Name = "gameOptionsToolStripMenuItem";
            this.gameOptionsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.gameOptionsToolStripMenuItem.Text = " M e n u";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // quitGameToolStripMenuItem
            // 
            this.quitGameToolStripMenuItem.Name = "quitGameToolStripMenuItem";
            this.quitGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitGameToolStripMenuItem.Text = "Quit Game";
            this.quitGameToolStripMenuItem.Click += new System.EventHandler(this.quitGameToolStripMenuItem_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.Blue;
            this.lblPlayer1.Location = new System.Drawing.Point(11, 23);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Padding = new System.Windows.Forms.Padding(2);
            this.lblPlayer1.Size = new System.Drawing.Size(245, 30);
            this.lblPlayer1.TabIndex = 10;
            this.lblPlayer1.Text = "Player 1";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPlayer2.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer2.Location = new System.Drawing.Point(11, 83);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Padding = new System.Windows.Forms.Padding(2);
            this.lblPlayer2.Size = new System.Drawing.Size(245, 30);
            this.lblPlayer2.TabIndex = 11;
            this.lblPlayer2.Text = "Player 2";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBarPlayer1
            // 
            this.pBarPlayer1.Location = new System.Drawing.Point(17, 56);
            this.pBarPlayer1.Maximum = 15;
            this.pBarPlayer1.Name = "pBarPlayer1";
            this.pBarPlayer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pBarPlayer1.Size = new System.Drawing.Size(239, 23);
            this.pBarPlayer1.Step = 1;
            this.pBarPlayer1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBarPlayer1.TabIndex = 12;
            // 
            // pBarPlayer2
            // 
            this.pBarPlayer2.Location = new System.Drawing.Point(17, 116);
            this.pBarPlayer2.Maximum = 15;
            this.pBarPlayer2.Name = "pBarPlayer2";
            this.pBarPlayer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pBarPlayer2.Size = new System.Drawing.Size(239, 23);
            this.pBarPlayer2.Step = 1;
            this.pBarPlayer2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBarPlayer2.TabIndex = 13;
            // 
            // timerPlayer1
            // 
            this.timerPlayer1.Interval = 1000;
            this.timerPlayer1.Tick += new System.EventHandler(this.timerPlayer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pBarPlayer2);
            this.groupBox2.Controls.Add(this.pBarPlayer1);
            this.groupBox2.Controls.Add(this.lblPlayer2);
            this.groupBox2.Controls.Add(this.lblPlayer1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(351, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 168);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seconds left:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTieGames);
            this.groupBox3.Controls.Add(this.lblPlayer2Score);
            this.groupBox3.Controls.Add(this.lblPlayer1Score);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(351, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 139);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Score Board ";
            // 
            // lblTieGames
            // 
            this.lblTieGames.AutoSize = true;
            this.lblTieGames.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTieGames.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTieGames.Location = new System.Drawing.Point(126, 94);
            this.lblTieGames.Name = "lblTieGames";
            this.lblTieGames.Padding = new System.Windows.Forms.Padding(2);
            this.lblTieGames.Size = new System.Drawing.Size(109, 30);
            this.lblTieGames.TabIndex = 16;
            this.lblTieGames.Text = "Tie Games:";
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPlayer2Score.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer2Score.Location = new System.Drawing.Point(6, 64);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Padding = new System.Windows.Forms.Padding(2);
            this.lblPlayer2Score.Size = new System.Drawing.Size(250, 30);
            this.lblPlayer2Score.TabIndex = 15;
            this.lblPlayer2Score.Text = "Player 2";
            this.lblPlayer2Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.ForeColor = System.Drawing.Color.Blue;
            this.lblPlayer1Score.Location = new System.Drawing.Point(6, 33);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Padding = new System.Windows.Forms.Padding(2);
            this.lblPlayer1Score.Size = new System.Drawing.Size(250, 30);
            this.lblPlayer1Score.TabIndex = 14;
            this.lblPlayer1Score.Text = "Player 1";
            this.lblPlayer1Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerPlayer2
            // 
            this.timerPlayer2.Interval = 1000;
            this.timerPlayer2.Tick += new System.EventHandler(this.timerPlayer2_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGameNumber,
            this.tsPlayersTurn,
            this.tsPointsToWinGame,
            this.tsCopyright});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(637, 24);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsGameNumber
            // 
            this.tsGameNumber.Name = "tsGameNumber";
            this.tsGameNumber.Padding = new System.Windows.Forms.Padding(2);
            this.tsGameNumber.Size = new System.Drawing.Size(99, 19);
            this.tsGameNumber.Text = "Game Number #";
            // 
            // tsPlayersTurn
            // 
            this.tsPlayersTurn.AutoSize = false;
            this.tsPlayersTurn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsPlayersTurn.Margin = new System.Windows.Forms.Padding(30, 3, 0, 2);
            this.tsPlayersTurn.Name = "tsPlayersTurn";
            this.tsPlayersTurn.Padding = new System.Windows.Forms.Padding(25, 2, 25, 2);
            this.tsPlayersTurn.Size = new System.Drawing.Size(131, 19);
            this.tsPlayersTurn.Text = "It\'s IME\'s turn!";
            // 
            // tsPointsToWinGame
            // 
            this.tsPointsToWinGame.Margin = new System.Windows.Forms.Padding(30, 3, 0, 2);
            this.tsPointsToWinGame.Name = "tsPointsToWinGame";
            this.tsPointsToWinGame.Padding = new System.Windows.Forms.Padding(2);
            this.tsPointsToWinGame.Size = new System.Drawing.Size(183, 19);
            this.tsPointsToWinGame.Text = "Chosen points to win the Game: ";
            // 
            // tsCopyright
            // 
            this.tsCopyright.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsCopyright.IsLink = true;
            this.tsCopyright.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.tsCopyright.Name = "tsCopyright";
            this.tsCopyright.Size = new System.Drawing.Size(92, 15);
            this.tsCopyright.Text = "-> Copyright <-";
            this.tsCopyright.Click += new System.EventHandler(this.tsCopyright_Click);
            // 
            // button0
            // 
            this.button0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button0.Location = new System.Drawing.Point(16, 23);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(90, 90);
            this.button0.TabIndex = 1;
            this.button0.TabStop = false;
            this.button0.UseMnemonic = false;
            this.button0.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(119, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 90);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(224, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 90);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(224, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 90);
            this.button5.TabIndex = 6;
            this.button5.TabStop = false;
            this.button5.UseMnemonic = false;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(119, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 90);
            this.button4.TabIndex = 5;
            this.button4.TabStop = false;
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(16, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 90);
            this.button3.TabIndex = 4;
            this.button3.TabStop = false;
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(224, 236);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 90);
            this.button8.TabIndex = 9;
            this.button8.TabStop = false;
            this.button8.UseMnemonic = false;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(119, 236);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 90);
            this.button7.TabIndex = 8;
            this.button7.TabStop = false;
            this.button7.UseMnemonic = false;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(16, 236);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 90);
            this.button6.TabIndex = 7;
            this.button6.TabStop = false;
            this.button6.UseMnemonic = false;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button0);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 340);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // pickColorsToolStripMenuItem1
            // 
            this.pickColorsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueRedToolStripMenuItem1,
            this.greenOrangeToolStripMenuItem1,
            this.purplePinkToolStripMenuItem1,
            this.blackGoldToolStripMenuItem1});
            this.pickColorsToolStripMenuItem1.Name = "pickColorsToolStripMenuItem1";
            this.pickColorsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pickColorsToolStripMenuItem1.Text = "Pick Colors:";
            // 
            // blueRedToolStripMenuItem1
            // 
            this.blueRedToolStripMenuItem1.Name = "blueRedToolStripMenuItem1";
            this.blueRedToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.blueRedToolStripMenuItem1.Text = "Blue - Red";
            this.blueRedToolStripMenuItem1.Click += new System.EventHandler(this.blueRedToolStripMenuItem_Click);
            // 
            // greenOrangeToolStripMenuItem1
            // 
            this.greenOrangeToolStripMenuItem1.Name = "greenOrangeToolStripMenuItem1";
            this.greenOrangeToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.greenOrangeToolStripMenuItem1.Text = "Green - Orange";
            this.greenOrangeToolStripMenuItem1.Click += new System.EventHandler(this.greenOrangeToolStripMenuItem_Click);
            // 
            // purplePinkToolStripMenuItem1
            // 
            this.purplePinkToolStripMenuItem1.Name = "purplePinkToolStripMenuItem1";
            this.purplePinkToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.purplePinkToolStripMenuItem1.Text = "Purple - Pink";
            this.purplePinkToolStripMenuItem1.Click += new System.EventHandler(this.purplePinkToolStripMenuItem_Click);
            // 
            // blackGoldToolStripMenuItem1
            // 
            this.blackGoldToolStripMenuItem1.Name = "blackGoldToolStripMenuItem1";
            this.blackGoldToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.blackGoldToolStripMenuItem1.Text = "Black - Gold";
            this.blackGoldToolStripMenuItem1.Click += new System.EventHandler(this.blackGoldToolStripMenuItem_Click);
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToPlayToolStripMenuItem.Text = "How to play ?";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 404);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.ProgressBar pBarPlayer1;
        private System.Windows.Forms.ProgressBar pBarPlayer2;
        private System.Windows.Forms.Timer timerPlayer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTieGames;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Timer timerPlayer2;
        private System.Windows.Forms.ToolStripMenuItem gameOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitGameToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsGameNumber;
        private System.Windows.Forms.ToolStripStatusLabel tsPlayersTurn;
        private System.Windows.Forms.ToolStripStatusLabel tsPointsToWinGame;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel tsCopyright;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pickColorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blueRedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem greenOrangeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem purplePinkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blackGoldToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
    }
}

