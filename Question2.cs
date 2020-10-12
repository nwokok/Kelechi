using System;
using System.Collections.Generic;

namespace Question2
{
    class Question2
    {
        public bool SameLists(List<int> listno1, List<int> listno2)
        {
            var isitTheSame = true;
            foreach (var i in listno1)
            {
                isitTheSame = (listno2.Contains(i) != false);
            }

            return isitTheSame;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
