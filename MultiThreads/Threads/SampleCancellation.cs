using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreads.Threads
{
    internal class SampleCancellation
    {
        public static void InitThreadCancellation()
        {
            Thread.CurrentThread.Name = "INI THREAD MAIN";
            Console.WriteLine($"Thread: {Thread.CurrentThread.Name}");

            //declare object cancellation
            CancellationTokenSource cts = new CancellationTokenSource();

            Thread threada = new Thread(SampleCancel.ExecuteMethod3);
            threada.Name = "Thread - A";
            Console.WriteLine("Thread a has been running");
            threada.Start(cts.Token);

            Thread.Sleep(1000);
            Console.WriteLine($"Cancellation in request.!!!");
            Thread.Sleep(1000);

            cts.Dispose();
            threada.Join();
            Console.WriteLine($"End of current thread: {Thread.CurrentThread.Name} END");

        }
    }

    internal class SampleCancel
    {
        public static void ExecuteMethod3 (object? token)
        {
            CancellationToken cToken = (CancellationToken) token;
            for (int i = 1; i < 100000; i++)
            {
                if (cToken.IsCancellationRequested)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} has been execute Method3");
                    Console.WriteLine($"iteration {i}, The Cancellation has  been request");
                    //cleanup operation
                    break;
                }
            }

            //the spinwait digunakan agar thread menunggu
            //dalam waktu tertentu yang di define di iteration params
            Thread.SpinWait( 500000 );
        }
    }
}
