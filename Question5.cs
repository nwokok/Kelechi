using System;
using System.Collections.Generic;

namespace Question5
{
    class Question5
    {
        public bool IsItASubset(List<int> list1, List<int> list2)
        {
            var List_Short = (list1.Count > list2.Count) ? list2 : list1;
            var List_Long = (list1.Count < list2.Count) ? list2 : list1;
            var checkList = new List<int>();
            foreach (var value in List_Short)
            {
                if (List_Long.Contains(value))
                    checkList.Add(value);
            }
            var isASubset = checkList.All(List_Short.Contains);
            return isASubset;
        }
        static void Main(string[] args)
        {

        }
    }
}
