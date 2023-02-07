using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreads.Threads
{
    internal class SampleThreadPool
    {
        public static void InitThreadPool()
        {
            Thread.CurrentThread.Name = "This Is Main Thread";
            Console.WriteLine($"Thread: {Thread.CurrentThread.Name}");

            //Call ThreadPool
            ThreadPool.QueueUserWorkItem(SampleThreadPool.ExecuteMethod3,100);

            Console.WriteLine($"End of current thread: {Thread.CurrentThread.Name} END");

        }

        public static void ExecuteMethod2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} from ExecuteMethod2 print: {i}");
            }
        }
        public static void ExecuteMethod3(object? value)
        {
            int upperLimit = Convert.ToInt32(value);
            for (int i = upperLimit - 3; i < upperLimit; i++)
            {
                Console.WriteLine($"The {Thread.CurrentThread.Name} from ExecuteMethod3 print: {i}");
                Thread.Sleep(10);
            }
        }

    }
}
