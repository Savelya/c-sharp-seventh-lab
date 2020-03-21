using System;
using System.Linq;

namespace seventh_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string text = Console.ReadLine();
            Console.WriteLine(String.Concat(text.OrderBy(c => c)));
        }
    }
}
