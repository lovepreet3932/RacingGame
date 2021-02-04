using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        Horse[] Horses = new Horse[4];

        PunterFactory pFactory = new PunterFactory();
        Punter[] punters = new Punter[3];

        public Form1()
        {
            InitializeComponent();
            SetupRaceTrack();
        }

        private void SetupRaceTrack()
        {

            Horse.StartingPosition1 = racer1.Left - racetrack.Right;
            Horse.RacetrackLength1 = racetrack.Size.Width - 100; //fixing length of race - till finish line

            Horses[0] = new Horse() { horsePictureBox = racer1 };
            Horses[1] = new Horse() { horsePictureBox = racer2 };
            Horses[2] = new Horse() { horsePictureBox = racer3 };
            Horses[3] = new Horse() { horsePictureBox = racer4 };

            punters[0] = pFactory.getPunter("P1", MaximumBet, P1Bet); //getting Pranshu object from factory class
            punters[1] = pFactory.getPunter("P2", MaximumBet, p2Bet); //getting Kumar object from factory class
            punters[2] = pFactory.getPunter("P3", MaximumBet, p3Bet); //getting Sachin object from factory class


            foreach (Punter punter in punters)
            {
                punter.UpdateLabels();
            }
        }

        private void PranshuButton_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[0].money);
        }

        private void KumarButton_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[1].money);
        }

        private void SachineButton_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[2].money);
        }

        private void setMaximumBetTextLabel(int Cash)
        {
            MaximumBet.Text = string.Format("Maximum Bet: ${0}", Cash);
        }

        // setting the bet for each Punter and updating labels respectively
       

       

        private void Bets_Click(object sender, EventArgs e)
        {
            int PunterNum = 0;

            if (P1Button.Checked)
            {
                PunterNum = 0;
            }
            if (P2Button.Checked)
            {
                PunterNum = 1;
            }
            if (P3Button.Checked)
            {
                PunterNum = 2;
            }

            punters[PunterNum].PlaceBet((int)BettingAmount.Value, (int)horseNumber.Value);
            punters[PunterNum].UpdateLabels();
        }

        private void race_Click(object sender, EventArgs e)
        {

            bool NoWinner = true;
            int winningHorse;
            race.Enabled = false; //disable start race button

            while (NoWinner)
            { // loop until we have a winner
                Application.DoEvents();
                for (int i = 0; i < Horses.Length; i++)
                {
                    if (Horse.Run(Horses[i]))
                    {
                        winningHorse = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner - horse #" + winningHorse);
                        foreach (Punter punter in punters)
                        {
                            if (punter.startbet != null)
                            {
                                punter.Collect(winningHorse); 
                                punter.startbet = null;
                                punter.UpdateLabels();
                            }
                        }
                        foreach (Horse Horse in Horses)
                        {
                            Horse.StartPosition();
                        }
                        break;
                    }
                }
            }
            if (punters[0].busted && punters[1].busted && punters[2].busted)
            {  //stop punters from betting if they run out of cash
                string message = "Do you want to Play Again?";
                string title = "GAME OVER!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SetupRaceTrack(); //restart game
                }
                else
                {
                    Close();
                }

            }
            race.Enabled = true; //enable race button 
        }

        private void racer1_Click(object sender, EventArgs e)
        {

        }

        private void P1Button_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

