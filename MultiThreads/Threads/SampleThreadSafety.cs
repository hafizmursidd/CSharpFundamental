using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreads.Threads
{
    internal class SampleThreadSafety
    {
        public static void InitThreadSafety()
        {
            //Create threadA
            ShareData shareData = new();
            Thread threadA = new Thread(shareData.Incerement);
            threadA.Start();

            //Create threadB
            Thread threadB= new Thread(shareData.Incerement);
            threadB.Start();
            //shareData.Incerement();
            threadA.Join();
            threadB.Join();

            Console.WriteLine($"Share Data Counter: "+shareData.Counter);
            
        }

        public static void InitThreadSafeWithLock()
        {
            ShareDataLock shareDataLock = new();
            Thread threada = new Thread(shareDataLock.Incerement);
            threada.Start();

            Thread threadb = new Thread(shareDataLock.Incerement);
            threadb.Start();

            threada.Join();
            threadb.Join();

            Console.WriteLine($"Share Data Lock Counter: " + shareDataLock.Counter);
        }
    }

    //share data not safe
    internal class ShareData
    {
        public int Counter { get; set; }
        public void Incerement() => Counter++;
    }

    //contoh thread safe
    internal class ShareDataLock
    {
        //create readonly object untuk lock
        private readonly object _counterLock = new object();
        private int _counter;

        public int Counter
        {
            get
            { 
               lock (_counterLock)
                {
                    return _counter;
                } 
            } 
        }
        public void Incerement()
        {
            lock (_counterLock)
            {
                _counter++;
            }
        }

    }



}
