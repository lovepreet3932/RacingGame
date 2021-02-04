using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Bet // beting class
    {
        public int Amount;
        public int NumHorse;
        public Punter Bettor;

        public Bet(int Amount, int numhorse, Punter Bettor)
        {
            this.Amount = Amount;
            this.NumHorse = numhorse;
            this.Bettor = Bettor;
        }

        public string GetDescription() 
        {
            string description = "";

            if (Amount > 0)
            {
                description = string.Format("{0} bets {1} on horse {2}", // bet on horse
                    Bettor.Title, Amount, NumHorse);
            }
            else
            {
                description = string.Format("{0} hasn't placed any bets",// bet has not placet yet
                    Bettor.Title);
            }
            return description;
        }

        public int Pay(int Winner)
        {
            if (NumHorse == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
