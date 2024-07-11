using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(20);
            Console.WriteLine(20 + 10);
            Console.WriteLine(20 - 10);
            Console.WriteLine(20 / 10);
            Console.WriteLine(20 * 10);

            // modulus operator
            Console.WriteLine(5 % 2);

            Console.WriteLine(5 - 2 + 10 * 2);
            Console.WriteLine(5 - (2 + 10) * 2);

            Console.WriteLine(5.0 + 3.1);

            Console.WriteLine(5 / 2);
            Console.WriteLine(5 / 2.0);

            int num1 = 6;
            Console.WriteLine(num1);

            num1++;
            Console.WriteLine(num1);

            num1--;
            Console.WriteLine(num1);

            // Math methods
            Console.WriteLine(Math.Abs(-14));
            Console.WriteLine(Math.Pow(5, 2));
            Console.WriteLine(Math.Pow(5.2, 2));
            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Max(25, 15));
            Console.WriteLine(Math.Min(25, 15));
            Console.WriteLine(Math.Round(2.4));
            Console.WriteLine(Math.Round(2.7));

            Console.ReadLine();
        }
    }
}