namespace ParallelForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new();

            frutas.Add("Apple");
            frutas.Add("Banana");
            frutas.Add("Pineapple");
            frutas.Add("Watermelon");
            frutas.Add("Pear");
            frutas.Add("Grape");
            frutas.Add("Fig");
            frutas.Add("Peach");
            frutas.Add("Orange");
            frutas.Add("Kiwi");
            frutas.Add("Mango");
            frutas.Add("Melon");
            frutas.Add("Strawberry");

            Console.WriteLine("Press Enter to start.");
            Console.ReadLine();

            Console.WriteLine("Displaying the list using single ForEach\n");
            foreach (var fruta in frutas)
            {
                Console.WriteLine($"Fruit: {fruta}, Thread Id ={ Thread.CurrentThread.ManagedThreadId} \t");
            }

            Console.WriteLine("\n\n Displaying the list using Parallel.ForEach:");
            Parallel.ForEach(frutas, fruta  => Console.WriteLine($"Fruta : {fruta}, Thread Id={Thread.CurrentThread.ManagedThreadId} \t"));

            Console.ReadLine();
        }
    }
}