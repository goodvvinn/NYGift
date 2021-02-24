using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetsGift
{
    public class Chocolate : Sweets
    {
        public Chocolate(int id, int cocoa, string name, double price, double weight)
            : base(id, name, price, weight)
        {
            Cocoa = cocoa;
        }

        public int Cocoa { get; set; }
        public override void Display()
        {
            base.Display();
            Console.Write($"|Cocoa : {Cocoa}|");
        }
    }
}
