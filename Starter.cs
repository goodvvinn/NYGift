using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetsGift
{
    public class Starter
    {
        public Starter()
        {
            Gift = new Gift();
            Gift.Display();
        }

        public Gift Gift { get; set; }
    }
}
