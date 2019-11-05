using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternPlaybook.Static
{
    public static class Funcs
    {

        private static Func<int, int> funcsquare = x => x*x;

        private static Func<int, string> IntToString = x => x.ToString();

        private static Func<string, bool> CompareString(string q)
        {
            return x => (q == x );
        }

        private static Func<CustomClass, bool> CompareClassString(string q)
        {
            return x => (q == x.Name) || (q == x.Description);
        }

        public static void MainFunc()
        {
            Console.WriteLine("Func takes an input and returns the OUTPUT. The last parameter.");
            
            Console.WriteLine("Func as a parameter.");
            WithFunc(funcsquare);


            Func<int, int> square = x => x*x;
            Func<int, int,int> add = (x,y) => x+y;

            Console.WriteLine("Plain func result");
            Console.WriteLine(square(3));
            Console.WriteLine(add(3,8));
            Console.WriteLine(IntToString(3));


            Console.WriteLine("Compare String");
            Console.WriteLine(CompareString("Test"));

            Console.WriteLine("Compare Class String");

            var list = new List<CustomClass>();
            var customClass = new CustomClass()
            {
                Name = "Name",
                Description = "description"
            };
            list.Add(customClass);
            list.Add(customClass);
            list.Add(customClass);
            list.Add(customClass);

            var found = list.Where(CompareClassString("Name")).ToList();
            Console.WriteLine(found.Count);
        }


        public static void WithFunc(Func<int, int> square1)
        {
            int it = square1(3);
            Console.WriteLine(it);

        }
    }





    public class CustomClass
    {
        public string Name {get;set;}
        public string Description {get;set;}
    }
}