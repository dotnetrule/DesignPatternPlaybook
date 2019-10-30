using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Composite
{
    public class MultipleOrder
    {
        public List<ItemOrder> orders = new List<ItemOrder>();


        public string Description
        {
            get { return ""; }
        }

        public int Total
        {
            //todo
            get { return orders.Count * 1; }
        }

        public void Add(ItemOrder item)
        {
            orders.Add(item);
        }




    }
}
