using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10, and press Enter.");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");

            else
                Console.WriteLine("Invalid");
        }
    }
}
