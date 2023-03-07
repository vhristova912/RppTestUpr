using System;
using System.Linq;

namespace listZad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("Count= " + string.Join(' ', names.Count(x => x.Length <= 3)));
            Array.Reverse(names);
            Console.WriteLine(string.Join(", ", names));
        }
    }
}
