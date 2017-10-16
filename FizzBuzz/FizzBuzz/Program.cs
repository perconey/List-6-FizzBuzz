using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string divByThree = "Fizz";
            string divByFive = "Buzz";
            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(divByThree + divByFive);
                        continue;
                    }
                    Console.WriteLine(divByThree);
                    continue;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine(divByFive);
                    continue;
                }
                Console.WriteLine(i);
                
            }
            Console.ReadKey();

        }
    }
}
