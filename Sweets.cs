using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetsGift
{
    public abstract class Sweets
    {
        public Sweets(int id, string name, double price, double weight)
        {
            Id = id;
            Name = name;
            Price = price;
            Weight = weight;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public int Id { get; set; }
        public virtual void Display()
        {
            Console.Write($"\n|Id :{Id}| |Name :{Name}| Price : {Price}| Weight : {Weight}|");
        }
    }
}