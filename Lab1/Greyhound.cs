using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public class Greyhound
    {
        public int startingPosition;
        public int raceTrackLength;
        public PictureBox myPictureBox;
        public int location = 0;
        public static readonly Random randomiser = new Random();

        public Greyhound(PictureBox myPB, int RaceTrackLength)
        {
            myPictureBox = myPB;
            startingPosition = myPB.Left;
            raceTrackLength = RaceTrackLength;
        }

        public bool Run()
        {
            //randomiser = new Random();
            //update postition            
            location += randomiser.Next(1, 4);
            myPictureBox.Left = startingPosition + location ;
            // if I won
            if (myPictureBox.Left >= 852)           
                return true;            
            else
                return false;
        }

        public void TakeStartingPosition()
        {
            //reset position to 0
            location = 0;
            myPictureBox.Left = startingPosition;
        }
    }
}
