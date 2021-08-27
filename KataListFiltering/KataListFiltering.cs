using System;
using System.Collections.Generic;
using System.Linq;

namespace KataListFiltering
{
    class KataListFiltering
    {
        static void Main(string[] args)
        {
            /* The following code could filter a given list and return a list of ints only:
               -->     return listOfItems.OfType<int>();
            */

            List<object> listOfItems = new List<object>() { 1, 2, "hi", 3, 4, "daniel" };
            List<object> numbers = new List<object>();
            foreach (var item in listOfItems)
            {
                if (!(item.GetType() == "".GetType()))
                {
                    numbers.Add(item);
                }
            }
            List<int> castedList = numbers.Select(s => (int)s).ToList();
            foreach (var num in castedList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
