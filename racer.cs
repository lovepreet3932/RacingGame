using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RacingGame
{
    public class Horse
    {
        private static int StartingPosition;
        private static int RacetrackLength;
        public PictureBox horsePictureBox = null;
        public int Location = 0;
       

        public static int StartingPosition1 { get => StartingPosition; set => StartingPosition = value; }
        public static int RacetrackLength1 { get => RacetrackLength; set => RacetrackLength = value; }

        // generation across all Bull objects
        public static Random MyRandom = new Random(); //declared random object
        public static bool Run(Horse obj)
        {
            int distance = MyRandom.Next(1, 10);
            if (obj.horsePictureBox != null)
                obj.MovehorsePictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (RacetrackLength1 - StartingPosition1))
            {
                return true;
            }
            return false;
        }

        public void StartPosition()
        {
            MovehorsePictureBox(-Location); //reset location 
            Location = 0;

        }

        public void MovehorsePictureBox(int distance)
        {
            Point p = horsePictureBox.Location;
            p.X -= distance;
            horsePictureBox.Location = p; //move horses
        }
    }
}
