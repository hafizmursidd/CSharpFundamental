using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Lambda
{
    internal class SimpleLambda
    {

        public static bool isEvenWithoutLambda(int number)
        {
            return number % 2==0;
        }
        public static bool isEven (int number) => number% 2==0;

        public static int Count(int[] Arr, Func<int, bool> isEven)
        {
            int Count = 0;
            foreach (int item in Arr)
            {
                if (isEven(item))
                { 
                    Count++;
                }
            }
            return Count;
        }


    }
}
