using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetsGift
{
    public class Gift
    {
        public Gift()
        {
            Sweet = new Sweets[]
            {
             new CreamJamCake(1, 300, 200, 15, "Fantazy", 50, 70),
             new WhiteChoc(2, 200, 220, "WiteNight", 50, 70),
             new Chocolate(3, 40,  "Millenium",  60,  100),
             new CreamCake(4, 30, 25, "Kharkiv", 80, 50),
             new CreamJamNutCake(5, 25, 15, 10, 5, "CrazyNuts", 120, 90),
             new Cake(6, 30, "Kyiv", 65, 70)
            };
            GetWeight();
        }

        public double TotalWeight { get; set; }

        public Sweets[] Sweet { get; set; }
        public void Display()
        {
            foreach (var item in Sweet)
            {
                item.Display();
            }

            Console.WriteLine();
            Console.Write("\nTotal weight of the gift =  ");
            DisplayWeight();
        }

        public void GetWeight()
        {
            TotalWeight = 0;
            foreach (var item in Sweet)
            {
                TotalWeight += item.Weight;
            }
        }

        public void DisplayWeight()
        {
            int intPart = 0;
            int fractPart = 0;
            intPart = (int)TotalWeight / 1000;
            fractPart = (int)TotalWeight - (intPart * 1000);
            if (TotalWeight > 1000)
            {
                Console.WriteLine($"{intPart} kg. {fractPart} g.");
            }
            else if (TotalWeight == 1000)
            {
                Console.WriteLine($"{intPart} kg.");
            }
            else
            {
                Console.WriteLine($"{TotalWeight} g.");
            }
        }
    }
}
