namespace ParallelFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to start.");
            Console.ReadLine();

            ProcessarLaco();
            Console.WriteLine("\n\n");
            Parallel.For(0,11, i=> Console.WriteLine(i+"\t"));
            Console.ReadLine();
        }

        private static void ProcessarLaco()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i+ "Thread : = "+
                    Thread.CurrentThread.ManagedThreadId+ "\t");
                Thread.Sleep(500);
            }
        }
    }
}
