using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Composite
{
    public class ItemOrder
    {
        private string code;
        private string name;
        private int price;

        public ItemOrder(string code, string name, int price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }

        public string Description
        {
            get { return (code + " - " + name).PadRight(25) + "EUR"; }
        }

        public int Price
        {
            get { return price; }
        }
    }
}
