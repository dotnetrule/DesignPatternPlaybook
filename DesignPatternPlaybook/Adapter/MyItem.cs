using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Adapter
{

    //Create to compatible thing
    public class MyItem : Item
    {
        private Hat Hat {get;set;}

        public MyItem(Hat hat)
        {
            this.Hat = hat;
        }

        public override string itemName()
        {
            return this.Hat.getName();
        }

        public override int itemPrice()
        {
            return this.Hat.getPrice();
        }
    }
}
