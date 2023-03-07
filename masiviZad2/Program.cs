using System;
using System.Linq;

namespace masiviZad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int b = int.Parse(Console.ReadLine());
            if (b>0)
            {
                Console.WriteLine("Count ="+ nums.Count(x=>x>=1 && x<=b));
            }
            else
            {
                Console.WriteLine("Invalid number b!");
            }
        }
    }
}
