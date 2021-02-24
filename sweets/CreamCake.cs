using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetsGift
{
    public class CreamCake : Cake
    {
        public CreamCake(int id, int cream, int meel, string name, double price, double weight)
            : base(id, meel, name, price, weight)
        {
            Cream = cream;
        }

        public int Cream { get; set; }
        public override void Display()
        {
            base.Display();
            Console.Write($"|Cream : {Cream}|");
        }
    }
}
