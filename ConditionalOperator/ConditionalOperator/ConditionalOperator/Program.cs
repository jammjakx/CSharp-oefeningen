using System;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGoldCostumer = true;

            //float price;
            //if (isGoldCostumer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            float price = (isGoldCostumer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
        }
    }
}
