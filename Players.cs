using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    using System.Windows.Forms;

    
   
        public class P1 : Punter // player1
        {
            public P1(Bet MyBet, Label MaximumBet, int Money, Label MyLabel) : base(MyBet, MaximumBet, Money, MyLabel)
            {
            }

            public override void setPunterName()
            {
                Title = "P1";
            }
        }

        public class P2 : Punter  // player2
    {
            public P2(Bet bet, Label MaximumBet, int Money, Label label) : base(bet, MaximumBet, Money, label)
            {
            }

            public override void setPunterName()
            {
                Title = "P2";
            }
        }

        public class P3 : Punter // player3
    {
            public P3(Bet bet, Label MaximumBet, int Money, Label label) : base(bet, MaximumBet, Money, label)
            {
            }

            public override void setPunterName()
            {
                Title = "P3";
            }
        }
    }

