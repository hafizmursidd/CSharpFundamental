using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdvancedCSharp.Delegate
{
    internal class SampleDelegate
    {

        public static int Sum(int a, int b) 
        {         
            return a + b; 
        }

        public static int Different (int a, int b)
        {
            return a - b;
        }

        public static void Show1() => Console.WriteLine($"Show 1 Called, Welcome ");
        public static void Show22(string Name) => Console.WriteLine($"Show 22 Called, Welcome {Name}");
        public static void Show2(string Name) => Console.WriteLine($"Show 2 Called, Welcome {Name}");
        public static void Show3(string Name) => Console.WriteLine($"Show 3 Called, Welcome {Name}");
        public static void Show4(string Name, int age) => Console.WriteLine($"Show 4 Called, Welcome {Name}, Age: {age}");
        public static void Show5(string Name, int age) => Console.WriteLine($"Show 5 Called, Welcome {Name}, Age: {age}");

        public static bool TestGreaater20(int number) {

            return number > 20;
        }

    }
    //delegate is reference type untuk call gunakan new operator
    public delegate int calculate(int a, int b);
}
