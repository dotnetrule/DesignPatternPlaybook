using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Composite
{
    public class ItemOrderSolution : IOrder
    {
        private string code;
        private string name;
        private int price;

        public ItemOrderSolution(string code, string name, int price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }

       

        string IOrder.Description()
        {
            throw new NotImplementedException();
        }

        public string Total()
        {
            return (code + " - " + name).PadRight(25) + "EUR"; 
        }
    }
}
