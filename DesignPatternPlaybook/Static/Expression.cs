using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DesignPatternPlaybook.Static
{
    public class Expression
    {
        private static Expression<Func<int, int>> square = x => x * x;
        
        public static void MainFunc()
        {
            Console.WriteLine("Func takes an input and returns the OUTPUT. The last parameter.");

            

        }
    }
}
