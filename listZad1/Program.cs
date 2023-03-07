using System;
using System.Collections.Generic;
using System.Linq;

namespace listZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //list manipolator
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                if(commands[0]== "end")
                        {
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                }
                switch (commands[0])
                {
                    case "statistic":
                        {
                            Console.WriteLine("Count=" + nums.Count());
                            Console.WriteLine("Sum=" + nums.Sum());
                            break;
                        }
                       
                    case "contains":
                        {
                            int num = int.Parse(commands[1]);
                            if (nums.Contains(num))
                            {
                                Console.WriteLine("YES");
                                nums.Remove(num);
                            }
                            break;
                        }
                       
                    case "remove":
                        {
                            int num1 = int.Parse(commands[1]);
                            nums.Remove(num1);
                            break;
                        }
                    
                       
                    default:
                        break;
                }
            }
            
        }
    }
}
