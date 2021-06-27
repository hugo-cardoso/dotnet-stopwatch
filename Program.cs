using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("== Input time: ==");
            Console.WriteLine("(Example: 1m, 35s)");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring((data.Length - 1), 1));
            int time = int.Parse(data.Substring(0, (data.Length - 1)));
            int multiplier = type == 's' ? 1 : 60;

            Start(time * multiplier);
        }

        static void Start(int time)
        {
            PreStart();

            int currentTime = 1;

            while (currentTime <= time)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime++;
                Thread.Sleep(1000);
            }

            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
            Menu();
        }

        static void PreStart()
        {
            int currentTime = 3;

            while (currentTime != 0)
            {
                Console.Clear();
                Console.WriteLine($"Starting in...{ currentTime }");
                currentTime--;
                Thread.Sleep(1000);
            }
        }
    }
}
