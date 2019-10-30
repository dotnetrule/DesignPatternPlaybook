using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Composite
{

    public class ProblemToAvoid
    {
        static void MainExample()
        {
            MultipleOrder firstOrder = new MultipleOrder();
            firstOrder.Add(new ItemOrder("80000", "item 1", 1500));

            MultipleOrder secondOrder = new MultipleOrder();
            secondOrder.Add(new ItemOrder("1234", "Voetbal", 1000));
            secondOrder.Add(new ItemOrder("7890", "Computer", 2300));

            MultipleOrder finalOrder = new MultipleOrder();
            foreach (ItemOrder itemOrder in firstOrder.orders)
            {
                finalOrder.Add(itemOrder);
            }
            foreach (ItemOrder itemOrder in secondOrder.orders)
            {
                finalOrder.Add(itemOrder);
            }



        }
    }
}
