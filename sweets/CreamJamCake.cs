using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetsGift
{
    public class CreamJamCake : CreamCake
    {
        public CreamJamCake(int id, int jam, int cream, int meel, string name, double price, double weight)
            : base(id, cream, meel, name, price, weight)
        {
            Jam = jam;
        }

        public int Jam { get; set; }
        public override void Display()
        {
            base.Display();
            Console.Write($"|Jam : {Jam}|");
        }
    }
}
