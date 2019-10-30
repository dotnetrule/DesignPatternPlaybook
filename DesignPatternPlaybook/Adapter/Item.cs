using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Adapter
{
    public class Item
    {
        private string name;
        private int price;

        public virtual string Description{ get; set; }

        public virtual string itemName()
        {
            return name;
        }

        public virtual int itemPrice()
        {
            return price;
        }
    }
}
