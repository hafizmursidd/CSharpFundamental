using MultiThreads.Threads;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //SampleThread.CreateBasicThread();

        //SampleThread.CreateThreadwithParam();

        //SampleThread.CreateThreadwithLambda();

        //SampleThread.CreateThreadBackground();

        //SampleThreadSafety.InitThreadSafety();
        //SampleThreadSafety.InitThreadSafeWithLock();


        //SampleCancellation.InitThreadCancellation();
        SampleThreadPool.InitThreadPool();



    }
}