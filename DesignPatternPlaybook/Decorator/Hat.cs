using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Decorator
{
    public class Hat : IHat
    {
        public Hat(string name, int price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        private string Name {get;set;}
        private int Price {get;set;}
        private string Description {get;set;}

        public string getName()
        {
            return Name;
        }

        public int getPrice()
        {
            return Price;
        }

        public string getDescription()
        {
            return Description;
        }
    }
}
