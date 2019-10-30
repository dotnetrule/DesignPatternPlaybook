using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Decorator
{
    public class PremiumHat : IHat
    {
        public PremiumHat()
        {
            Name = "Premium Hat";
            Price = 30;
            Description = "";
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
