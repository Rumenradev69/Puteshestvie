using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puteshestvie
{
    internal class Controller
    {
        private Travel travel;
        private Display display;

        public Controller()
        {
            travel = new Travel();
            display = new Display();
        }

        public void Start()
        {
            travel.Budget = display.GetBudget();
            travel.Season = display.GetSeason();

            travel.CalculateDestinationAndCost();
            display.ShowResult(travel.Destination, travel.Accommodation, travel.SpentAmount);
        }
    }
}
