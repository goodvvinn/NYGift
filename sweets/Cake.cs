using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetsGift
{
    public class Cake : Sweets
    {
        public Cake(int id, int meel, string name, double price, double weight)
            : base(id, name, price, weight)
        {
            Meel = meel;
        }

        public int Meel { get; set; }

        public override void Display()
        {
            base.Display();
            Console.Write($"|Meel :{Meel}|");
        }
    }
}
