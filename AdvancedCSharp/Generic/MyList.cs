using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generic
{
    internal class MyList
    {
        public static void DisplayListString() { 
        
        List<string> list = new List<string>();

            list.Add("Code Id");
            list.Add("Bootcamp");
            list.Add("DotNet");

            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void DisplayListInt()
        {

            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }


    }
}
