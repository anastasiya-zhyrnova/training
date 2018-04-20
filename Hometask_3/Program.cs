using System;

namespace Hometask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer value from 0 to 100 inclusive");

            Console.WriteLine(new NumberCheck().ValidateNumber());

            Console.ReadKey();

        }
    }
}
