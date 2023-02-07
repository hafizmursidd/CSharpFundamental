using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreads.Threads
{
    internal class SampleThread
    {
        public static void CreateBasicThread()
        {
            //1 set main thread name to 'main'
            Thread.CurrentThread.Name = "This Is Main Thread";
            Console.WriteLine($"Thread: {Thread.CurrentThread.Name}");

            //2 create child thread1
            Thread thread1 = new Thread(SampleThread.ExecuteMethod1);
            thread1.Name = "This is thread One";

            //3 create child thread2
            Thread thread2 = new Thread(SampleThread.ExecuteMethod2);
            thread2.Name = "This is thread Two";

            //4 start running therad1
            Console.WriteLine($"Run Thread One");
            thread1.Start();

            //5 slow down thread using method sleep
            Thread.Sleep(1);

            //6 start running thread2
            Console.WriteLine($"Run Thread Two");
            thread2.Start();

            //call method join
            //waiting thread one finished
            thread1.Join();
            //waiting thread one finished
            thread2.Join();

            //7 display end current thread
            Console.WriteLine($"End of current thread: {Thread.CurrentThread.Name} END");
        }


        public static void CreateThreadBackground()
        {
            Thread threadBack = new(
                    () =>
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"Thread Background: {Thread.CurrentThread.Name} print {i}");
                            Thread.Sleep(1000);
                        }
                        Console.WriteLine(Thread.CurrentThread.Name+ " Finished running");
                    }
                );
            threadBack.Name = "Child-Thread";
            threadBack.Start();
            threadBack.IsBackground = false;
        }
        public static void CreateThreadwithParam()
        {
            Thread thread3 = new Thread(SampleThread.ExecuteMethod3);
            thread3.Name = "This is Thread 3";
            Console.WriteLine("Thread 3 has been running");
            thread3.Priority = ThreadPriority.Highest;
            thread3.Start(15);
            thread3.Join();
        }

        public static void CreateThreadwithLambda()
        {
            int result = 0;
            Thread threadLambda = new Thread(
                    (n) =>
                    {
                        Console.WriteLine($"The {Thread.CurrentThread.Name} has been Execute");
                        try
                        {
                            int temp = Convert.ToInt32(n);
                            result = temp + 100;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception: "+e);
                        }
                    }
                    );

            threadLambda.Name = "Thread with Lambda";
            threadLambda.Start();
            threadLambda.Join();
            Console.WriteLine($"The Result is: {result}");
        }
        public static void ExecuteMethod1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} from ExecuteMethod1 print: {i}");
            }
        }

        public static void ExecuteMethod2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} from ExecuteMethod2 print: {i}");
            }
        }

        public static void ExecuteMethod3 (object? value)
        {
            int upperLimit = Convert.ToInt32(value);
            for (int i = upperLimit - 3; i < upperLimit; i++)
            {
                Console.WriteLine($"The {Thread.CurrentThread.Name} from ExecuteMethod3 print: {i}");
                Thread.Sleep(100);
            }
        }
    }
}
