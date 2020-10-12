using System;
using System.Collections.Generic;

namespace Question4
{
    class Question4
    {
        public void repeat(List<int> list)
        {
            var scan = new List<int>();
            var duplication = new List<int>();

            for (var i = 0; i <= list.Count - 2; i++)
            {
                scan.Add(list[i]);

                if (scan.Contains(list[i + 1]))
                {
                    duplication.Add(list[i + 1]);
                }

            }

            foreach (var number in duplication)
            {
                Console.WriteLine(number);
            }
        }
        
        static void Main(string[] args)
        {

        }
    }
}
