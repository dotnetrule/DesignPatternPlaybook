using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Decorator
{
    public class RibbonedHat : IHat
    {

        private IHat Hat { get;set;}

        public RibbonedHat(IHat hat)
        {
            this.Hat =hat;
            Name = "Ribboned";
            Price = 1;
            Description = "";
        }

        private string Name {get;set;}
        private int Price {get;set;}
        private string Description {get;set;}

        public string getName()
        {
            return $"{Hat.getName()} {Name}";
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
