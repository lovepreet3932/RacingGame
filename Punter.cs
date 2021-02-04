using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public abstract class Punter
    {
        public string Title;
        public Bet startbet;
        public int money;
        public bool busted;
        public Label statusLabel, MaximumBet;

        public abstract void setPunterName();

        public Punter(Bet bet, Label MaximumBet, int Cash, Label statusLabel) // place bet
        {
            this.startbet = bet;
            this.money = Cash;
            this.MaximumBet = MaximumBet;
            this.statusLabel = statusLabel;
            if (this.statusLabel != null)
                this.statusLabel.ForeColor = System.Drawing.Color.Black;

        }
      
        public void UpdateLabels()
        {
            if (startbet == null)
            {
                statusLabel.Text = String.Format("{0} hasn't placed any bets", Title);
            }

            else
            {
                statusLabel.Text = startbet.GetDescription();
            }
            if (money == 0)
            {
                busted = true;
                statusLabel.Text = String.Format("BUSTED!");
                statusLabel.ForeColor = System.Drawing.Color.Red;

            }
            MaximumBet.Text = String.Format("Maximum Bet: ${0}", money);
        }


        public void ClearBet()
        {
            startbet.Amount = 0;
        }
        public void Collect(int Winner) // winner
        {
            money += startbet.Pay(Winner);
        }
        public bool PlaceBet(int Amount, int horse)
        {
            if (Amount <= money)
            {
                startbet = new Bet(Amount, horse, this);
                return true;
            }
            return false;
        }

    }
}
