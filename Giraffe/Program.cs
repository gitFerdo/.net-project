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
            // integer array
            int[] array = { 4, 5, 8, 2, 10 };

            // if want to change the number of elements
            array[2] = 100;

            Console.WriteLine(array[2]);

            // string array
            string[] stringArray = new string[5];

            stringArray[0] = "John";
            stringArray[1] = "Nike";

            Console.WriteLine(stringArray[0]);

            // Console.ReadLine();
        }
    }
}