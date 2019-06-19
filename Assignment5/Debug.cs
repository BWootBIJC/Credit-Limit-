using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Debug
    {
        static void Main(string[] args)
        {
            int age = 0;
            if (age >= 65)
            {
                Console.WriteLine("Age greater than or equal to 65.");
            }
            else
            {
                Console.WriteLine("Age is less than 65.");
            }
            int x = 1, total = 0;
            while (x <= 10) 
            {
                total += x;
                ++x;
            }
            while (x <= 100)
            {
                total += x;
                ++x;
            }
            int y = 0;
            while (y > 0)
            {
                Console.WriteLine(y);
                ++y;
            }
            Console.ReadKey();
        }
    }
}
