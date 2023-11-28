using System;

namespace Consoleapp50
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];
            tal[0] = 24;
            tal[1] = 23;

            Console.WriteLine("Välj det tredje talet");
            tal[2] = int.Parse(Console.ReadLine());

            Console.WriteLine(tal[0] + " " + tal[1] + " " + tal[2]);
            
        }
    }
}