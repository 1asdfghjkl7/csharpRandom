using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Create a list
            List<int> randList = new List<int>();
            // Populate the list
            for (int i = 0; i < 20; i++)
            {
                randList.Add(random.Next(1, 51));
            }

            List<int> sqrList = new List<int>();
            List<int> sqrListNoOdd = new List<int>();

            foreach (var item in randList)
            {
                sqrList.Add(item ^ 2);
            }

            foreach (var item in sqrList)
            {
                if (item % 2 == 0)
                {
                    sqrListNoOdd.Add(item);
                }
            }

            foreach (var item in sqrListNoOdd)
            {
                Console.WriteLine(item);

            }

        }
    }
}
