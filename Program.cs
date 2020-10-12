using System;
using System.Collections.Generic;

namespace Question6
{
    class Program
    {
        public void Reverse(List<int> list1)
        {
            Display(list1);
            
            for (int i = 0; i <= list1.Count / 2; i++)
            {
                var number = list1[i];
                var Variable = number;
                list1[i] = list1[list1.Count - (i + 1)];
                list1[list1.Count - (i + 1)] = Variable;
            }
            
            Display(list1);
        }

        private static void Display(IEnumerable<int> myList)
        {
            Console.WriteLine();
            Console.WriteLine();
            
            foreach (var number in myList)
            {
                Console.WriteLine(number);
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
