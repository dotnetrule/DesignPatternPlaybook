using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Composite
{
    public class MultipleOrderSolution : IOrder
    {
        public List<IOrder> orders = new List<IOrder>();


        public void Add(IOrder item)
        {
            orders.Add(item);
        }


        string IOrder.Description()
        {
            throw new NotImplementedException();
        }

        string IOrder.Total()
        {
            throw new NotImplementedException();
        }
    }
}
