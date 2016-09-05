using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frog
{
    class Program
    {
        static List<string> combinations = new List<string>();
        static int[] numbers = new int[2] { 1, 2 };
        public static int NumberOfWays(int n)
        {
            GetCombinations("", n);

            return combinations.Count;
        }

        public static void GetCombinations(string current, int total)
        {
            Debug.WriteLine(current);
            var currentTotal = ComputeTotal(current);
            if (currentTotal == total)
            {
                Debug.WriteLine("Adding... " + current);
                combinations.Add(current);
            }
            
            if (currentTotal < total)
            {
                foreach (var number in numbers)
                {
                    GetCombinations(current + number, total);
                }
            }
        }

        public static int ComputeTotal(string input)
        {
            var output = 0;
            foreach (var item in input.ToCharArray())
            {
                output = output + Convert.ToInt16(item.ToString());
            }

            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfWays(3));
        }
    }
}
