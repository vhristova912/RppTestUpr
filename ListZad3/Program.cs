using System;
using System.Collections.Generic;
using System.Linq;

namespace ListZad3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string cmd = input[0];
                if (cmd == "print")
                {
                    Console.WriteLine(string.Join(" ", nums));
                    break;

                }
                switch (cmd)
                {
                    case "add":
                        var index = int.Parse(input[1]);
                        var element = int.Parse(input[2]);
                        nums.Insert(index, element);
                        break;
                    case "addMany":
                        index = int.Parse(input[1]);
                        for (int i = input.Length - 1; i > 1; i--)
                        {
                            element = int.Parse(input[i]);
                            nums.Insert(index, element);
                        }
                        break;
                    case "contains":
                        element = int.Parse(input[1]);
                        Console.WriteLine(nums.IndexOf(element));
                        break;
                    case "remove":
                        index = int.Parse(input[1]);
                        nums.RemoveAt(index);
                        break;
                    case "shift":
                        var position = int.Parse(input[1]);
                        for (int i = 0; i < position % nums.Count(); i++)
                        {
                            int elememt = nums[0];
                            nums.RemoveAt(0);
                            nums.Add(elememt);
                        }
                        break;
                    case "sumPairs":
                        var result = new List<int>();
                        for (int i = 0; i < nums.Count; i = i + 2)
                        {
                            result.Add(nums[i] + nums[i + 1]);
                        }
                        nums = result;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
