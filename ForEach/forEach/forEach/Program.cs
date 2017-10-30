using System;
using System.Runtime.InteropServices;

namespace forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] {1, 2, 3, 4};

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}



//DELETED CODE
//var name = "John Smith";

////for (var i = 0; i < name.Length; i++)
////{
////    Console.WriteLine(name[i]);
////}

//foreach (var character in name)
//{
//Console.WriteLine(character);
//}