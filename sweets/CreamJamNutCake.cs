using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetsGift
{
    public class CreamJamNutCake : CreamJamCake
    {
        public CreamJamNutCake(int id, int nuts, int jam, int cream, int meel, string name, double price, double weight)
            : base(id, jam, cream, meel, name, price, weight)
        {
            Nuts = nuts;
        }

        public int Nuts { get; set; }
        public override void Display()
        {
            base.Display();
            Console.Write($"|Nuts : {Nuts}|");
        }
    }
}
