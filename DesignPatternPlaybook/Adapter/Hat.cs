using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Adapter
{
    //Incompatible with shopping cart
    public class Hat
    {
        private string Name;
        private int Price;
        public string Description;


        public string getName()
        {
            return Name;
        }

        public int getPrice()
        {
            return Price;
        }
    }
}
