using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetsGift
{
    public class WhiteChoc : Chocolate
    {
        public WhiteChoc(int id, int milk, int cocoa, string name, double price, double weight)
            : base(id, cocoa, name, price, weight)
        {
            Milk = milk;
        }

        public int Milk { get; set; }
        public override void Display()
        {
            base.Display();
            Console.Write($"|Milk :{Milk}|");
        }
    }
}
