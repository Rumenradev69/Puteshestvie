using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puteshestvie
{
    internal class Travel
    {
        public double Budget { get; set; }
        public string Season { get; set; }
        public string Destination { get; set; }
        public string Accommodation { get; set; }
        public double SpentAmount { get; set; }

        public void CalculateDestinationAndCost()
        {
            if (Budget <= 100)
            {
                Destination = "Bulgaria";
                if (Season == "Summer")
                {
                    SpentAmount = Budget * 0.30;
                    Accommodation = "Camp";
                }
                else
                {
                    SpentAmount = Budget * 0.70;
                    Accommodation = "Hotel";
                }
            }
            else if (Budget <= 1000)
            {
                Destination = "Balkans";
                if (Season == "Summer")
                {
                    SpentAmount = Budget * 0.40;
                    Accommodation = "Camp";
                }
                else
                {
                    SpentAmount = Budget * 0.80;
                    Accommodation = "Hotel";
                }
            }
            else
            {
                Destination = "Europe";
                SpentAmount = Budget * 0.90;
                Accommodation = "Hotel";
            }
        }
    }
}
