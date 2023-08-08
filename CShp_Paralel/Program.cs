using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cshp_Paralel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press the Enter to start");
            Console.ReadLine();

            //call the method to execute 

            //Parallel.Invoke(new Action(ExibirMeses),
            //    new Action(ExibirDias),
            //    new Action(ExibirCidade));

            //call the method to execute  with expression lambda
            Parallel.Invoke(() => ExibirMeses(),
                            () => ExibirDias(),
                            () => ExibirCidade());

            //Wait the continue program
            Console.WriteLine("\nThe method is finished. Press Enter");
            Console.ReadLine();
        }

        static void ExibirDias()
        {
            string[] diasArray = { "Monday", "Thusday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            foreach (var dia in diasArray)
            {
                Console.WriteLine($"Day :  {dia}");
                Thread.Sleep(1500);
            }
        }
        // Show the month
        static void ExibirMeses()
        {
            string[] mesArray = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };
            foreach(var mes in mesArray) 
            {
                Console.WriteLine($"Month: {mes}");
                Thread.Sleep(1200);
            }
        }
        // show city
        static void ExibirCidade()
        {
            string[] cidadesArray = { "London", "New York", "Paris", "Tokyo", "Sydney", "Sao Paulo" };
            foreach (var cidade in cidadesArray)
            {
                Console.WriteLine($"City : {cidade}");
                Thread.Sleep(2000);
            }
        }

    }
}