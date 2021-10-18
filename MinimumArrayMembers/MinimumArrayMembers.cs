using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumArrayMembers
{
    class MinimumArrayMembers
    {
        static void Main(string[] args)
        {
            
            var input = Console.ReadLine();
            var arr = input.Split(' ').Select(x => int.Parse(x)).ToList();
            var S = arr[0];
            arr.RemoveAt(0);
            var sum = 0;
            var counter = 0;
            foreach (int i in arr.OrderByDescending(x => x))
            {
                counter++;
                sum += i;

                if (sum > S)
                {
                    Console.Write(counter);
                    break;
                }
                
            }
            if (sum <= S)
            {
                Console.Write(-1);
            }
            
        }
    }
}
