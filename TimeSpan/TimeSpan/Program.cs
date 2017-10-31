using System;

namespace TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new System.TimeSpan(1, 2, 3);

            var timeSpan1 = new System.TimeSpan(1, 0, 0);
            var timeSpan2 = new TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("duration: " + duration);

            //properties
            Console.WriteLine("minutes: " + timeSpan.Minutes);
            Console.WriteLine("total minutes: " + timeSpan.TotalMinutes);

            //add
            Console.WriteLine("add example: " + timeSpan.Add(timeSpan.FromMinutes(8)));
            Console.WriteLine("subtract example: " + timeSpan.Subtract(timeSpan.FromMinutes(2)));

            //tostring
            Console.WriteLine("tostring" + timeSpan.ToString());

            //parse
            Console.WriteLine("parse: " + timeSpan.parse("01:02:03"));
        }
    }
}
