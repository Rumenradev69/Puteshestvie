using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puteshestvie
{
    internal class Display
    {
        public double GetBudget()
        {
            Console.Write("Въведете бюджет: ");
            return double.Parse(Console.ReadLine());
        }

        public string GetSeason()
        {
            Console.Write("Въведете сезон (summer/winter): ");
            return Console.ReadLine();
        }

        public void ShowResult(string destination, string accommodation, double spentAmount)
        {
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accommodation} - {spentAmount:F2}");
        }
    }
}
