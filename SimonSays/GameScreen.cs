using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        int userGuess = 0;


        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.patternList.Clear();
            Refresh();
            Thread.Sleep(1000);
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            Random randNum = new Random();
            Form1.patternList.Add(randNum.Next(0, 4));

            for (int i = 0; i < Form1.patternList.Count; i++)
            {
                if (Form1.patternList[i] == 0)
                {
                    redButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(300);
                    redButton.BackColor = Color.DarkRed;
                    Refresh();
                    Thread.Sleep(300);
                }

                if (Form1.patternList[i] == 1)
                {
                    greenButton.BackColor = Color.LightGreen;
                    Refresh();
                    Thread.Sleep(300);
                    greenButton.BackColor = Color.DarkGreen;
                    Refresh();
                    Thread.Sleep(300);
                }

                if (Form1.patternList[i] == 2)
                {
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(300);
                    yellowButton.BackColor = Color.Goldenrod;
                    Refresh();
                    Thread.Sleep(300);
                }

                if (Form1.patternList[i] == 3)
                {
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(300);
                    blueButton.BackColor = Color.DarkBlue;
                    Refresh();
                    Thread.Sleep(300);
                }
            }

            userGuess = 0;
        }

        public void GameOver()
        {
            SoundPlayer gameOver = new SoundPlayer(Properties.Resources.gameover);
            gameOver.Play();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameOverScreen gos = new GameOverScreen();
            f.Controls.Add(gos);

            gos.Location = new Point((f.Width - gos.Width) / 2, (f.Height - gos.Height) / 2);

        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.patternList[userGuess] == 1)
            {
                greenButton.BackColor = Color.LightGreen;

                SoundPlayer greenbuttonclick = new SoundPlayer(Properties.Resources.green);
                greenbuttonclick.Play();

                Refresh();
                Thread.Sleep(100);

                greenButton.BackColor = Color.DarkGreen;
                Refresh();
                Thread.Sleep(300);


                userGuess++;

                if (userGuess >= Form1.patternList.Count())
                {
                    ComputerTurn();
                }

            }

            else
            { GameOver(); }
        }

        private void redButton_Click_1(object sender, EventArgs e)
        {
            if (Form1.patternList[userGuess] == 0)
            {
                redButton.BackColor = Color.Red;

                SoundPlayer redbuttonclick = new SoundPlayer(Properties.Resources.red);
                redbuttonclick.Play();

                Refresh();
                Thread.Sleep(100);

                redButton.BackColor = Color.DarkRed;
                Refresh();
                Thread.Sleep(300);

                userGuess++;

                if (userGuess >= Form1.patternList.Count())
                {
                    ComputerTurn();
                }
            }

            else
            { GameOver(); }
        }

        private void yellowButton_Click_1(object sender, EventArgs e)
        {
            if (Form1.patternList[userGuess] == 2)
            {
                yellowButton.BackColor = Color.Yellow;

                SoundPlayer yellowbuttonclick = new SoundPlayer(Properties.Resources.yellow);
                yellowbuttonclick.Play();

                Refresh();
                Thread.Sleep(100);

                yellowButton.BackColor = Color.Goldenrod;
                Refresh();
                Thread.Sleep(300);

                userGuess++;

                if (userGuess >= Form1.patternList.Count())
                {
                    ComputerTurn();
                }

            }

            else
            { GameOver(); }
        }

        private void blueButton_Click_1(object sender, EventArgs e)
        {
            if (Form1.patternList[userGuess] == 3)
            {
                blueButton.BackColor = Color.Blue;

                SoundPlayer bluebuttonclick = new SoundPlayer(Properties.Resources.blue);
                bluebuttonclick.Play();

                Refresh();
                Thread.Sleep(100);

                blueButton.BackColor = Color.DarkBlue;
                Refresh();
                Thread.Sleep(300);

                userGuess++;

                if (userGuess >= Form1.patternList.Count())
                {
                    ComputerTurn();
                }
            }

            else
            { GameOver(); }
        }
    }
}
