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
            SayHi("Mike", 25);
            SayHi("John", 23);
            SayHi("Tom", 56);

            // Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello! " + name + "\nAge: " + age);
        }
    }
}