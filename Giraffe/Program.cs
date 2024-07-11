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
            Console.WriteLine("Giraffe Academy");
            Console.WriteLine("Giraffe\nAcademy");
            Console.WriteLine("Giraffe\"Academy");

            string phrase = "Giraffe Academy";
            Console.WriteLine(phrase);

            string phrase2 = "Giraffe Academy" + " is cool.";
            Console.WriteLine(phrase2);

            // find how many characters in the phrase
            Console.WriteLine(phrase.Length);

            // methods in the string
            // 1. Convert to uppercase
            Console.WriteLine(phrase.ToUpper());

            // 2. Convert to lowercase
            Console.WriteLine(phrase.ToLower());

            // 3. Contains method
            Console.WriteLine(phrase.Contains("Academy"));
            Console.WriteLine(phrase.Contains("Acadeis"));

            // 4. letter in the string 
            Console.WriteLine(phrase[0]); // first letter
            Console.WriteLine(phrase[1]);
            Console.WriteLine(phrase[6]);
            Console.WriteLine(phrase[8]);

            // 5. find index position that value is located in the string
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.IndexOf("f"));
            Console.WriteLine(phrase.IndexOf("z"));

            // 6. print part of the string
            Console.WriteLine(phrase.Substring(8));
            Console.WriteLine(phrase.Substring(8, 3));


            Console.ReadLine();
        }
    }
}