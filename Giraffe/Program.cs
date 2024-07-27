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
            // calling to method
            Console.WriteLine(Cube(5));

            int cubeNumber = Cube(3);
            Console.WriteLine(cubeNumber);

            // Console.ReadLine();
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}