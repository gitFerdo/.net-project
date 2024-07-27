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
            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are Tall & Male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are short man");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are female but you are tall");
            }
            else
            {
                Console.WriteLine("You are not Tall & female");
            }

            // Console.ReadLine();
        }
    }
}