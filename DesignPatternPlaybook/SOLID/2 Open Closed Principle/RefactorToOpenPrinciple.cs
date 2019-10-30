using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternPlaybook.SOLID._2_Open_Closed_Principle
{
    internal class RefactorToOpenPrinciple
    {

        //  1 Usage of Parameters in programs to avoid static code
        //  Allow client to control behaviour specifics via a parameter
        //  Combined with delegates/lambda, can be very powerful approach 



        //  2 inheritence/Template Method Patern
        //  Child types override behaviour of a base class



        //  3 Composition / Strategy Pattern
        //  Client code depends on abstraction
        //  Provides a plug in model
        //  Implementations utilize Inheritence Client utilizes Composition

        
        // Violation of OPEN CLOSED PRINCIPLE can be identified when classes or functions depend on being 'opened' or 'closed' through editing other classes.

        //Example of how to avoid IF statements
        public class Cart
        {
            private readonly List<OrderItem> _items;
            private readonly IPricingCalculator _pricingCalculator;

            public Cart(IPricingCalculator pricingCalculator)
            {
                _pricingCalculator = pricingCalculator;
                _items = new List<OrderItem>();
            }

            public IEnumerable<OrderItem> Items
            {
                get { return _items; }
            }

            public string CustomerEmail {get;set;}

            public void Add(OrderItem orderItem)
            {
                _items.Add(orderItem);
            }

            public decimal TotalAmount()
            {
                decimal total = 0m;
                foreach (var orderItem in Items)
                {
                    total += _pricingCalculator.CalculatePrice(orderItem);
                }

                return total;
            }
        }

    }

    internal interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }


    internal class PricingCalculator : IPricingCalculator
    {
        private readonly List<IPriceRule> _pricingRules;

        public PricingCalculator()
        {
            _pricingRules = new List<IPriceRule>();
            _pricingRules.Add(new EachPriceRule());
            _pricingRules.Add(new PerGramPriceRule());
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return _pricingRules.First(r => r.IsMatch(item)).CalculatePrice(item);
        }
    }

    


    internal interface IPriceRule
    {
        bool IsMatch(OrderItem item);
        decimal CalculatePrice(OrderItem item);
    }

    internal class EachPriceRule : IPriceRule
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("EACH");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * 5m;
        }
    }

    internal class PerGramPriceRule : IPriceRule
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("WEIGHT");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * 4m / 1000;
        }
    }

    internal class OrderItem
    {
        public string Name {get;set;}
        public string Sku {get;set;}
        public int Quantity {get;set;}
        public int Price { get;set; }
    }
}
