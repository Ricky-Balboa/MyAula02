using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "isto é uma string ";
            string b = @"Isto é uma string verbatim/literal";
            string c = " Unicode -> \u0081";
            string d = " Unicode -> \u03A6";
            string Break = "------------------------------------------------------";

            Console.WriteLine(a);
            Console.WriteLine(Break);
            Console.WriteLine(b);
            Console.WriteLine(Break);
            Console.WriteLine(c);
            Console.WriteLine(Break);
            Console.WriteLine(d);
            Console.WriteLine(Break);
            Console.WriteLine("Enter Para Fechar.");
            Console.ReadKey();

        }
    }
}
