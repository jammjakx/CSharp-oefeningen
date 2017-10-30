using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("the maximum amout of these 2 mubers is " + max);
        }
    }
}
