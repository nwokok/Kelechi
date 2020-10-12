using System;
using System.Collections.Generic;

namespace Question3
{
    class Question3
    {
        public Question3(List<int> list)
        {
            MyList = list;
            BubbleSortCode();
        }

        public List<int> MyList { get; }
        public bool Search(int item)
        {
            var isitInList = false;
            foreach (var i in MyList)
            {
                if (i == item)
                {
                    isitInList = true;
                    break;
                }
            }

            return isitInList;
        }

        public bool SmartSearch(int item)
        {
            var isInMyList = false;
            var beginning = MyList.Count / 2;
            if (item <= MyList[MyList.Count / 2])
            {
                for (; beginning >= 0; beginning--)
                {
                    if (MyList[beginning] != item) continue;
                    isInMyList = true;
                    break;
                }
            }
            else
            {
                for (; beginning <= MyList.Count - 1; beginning++)
                {
                    if (MyList[beginning] == item)
                    {
                        isInMyList = true;
                        break;
                    }
                }
            }

            return isInMyList;
        }

        private void BubbleSortCode()
        {
            for (var j = 0; j < MyList.Count; j++)
            {
                for (var i = 0; i <= MyList.Count - 2; i++)
                {
                    if (MyList[i] <= MyList[i + 1]) continue;
                    var temp = MyList[i];
                    MyList[i] = MyList[i + 1];
                    MyList[i + 1] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
        
        }
    }
}
