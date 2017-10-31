using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3, 7, 9, 2, 14, 6};

            //length
            Console.WriteLine("Length: " + numbers.Length);

            //indexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("index of 9: " + index);

            // clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effects of clear()");

            foreach (var n in numbers)
                Console.WriteLine(n);

            //copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effects of sort()");
            foreach (var n in another)
            Console.WriteLine(n);

            //sort()
            Array.Sort(numbers);

            Console.WriteLine("Effects of sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effects of reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);

        }
    }
}
