using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Decorator
{
    public class StandardHat : IHat
    {
        public StandardHat()
        {
            Name = "Standard Hat";
            Price = 20;
            Description = "Standard Hat";
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
