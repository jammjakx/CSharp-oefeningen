using System;

namespace Season
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Seasons.Autumn;

            switch (season)
            {
                case Seasons.Autumn:
                case Seasons.Summer:
                    Console.WriteLine("We've got promotion");
                    break;

                default:
                    Console.WriteLine("I don't understand that season");
                    break;
            }
        }
    }
}
