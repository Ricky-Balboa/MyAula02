using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Isto é uma string ";
            string b = @"Isto é uma string verbatim/literal";
            string c = " Unicode -> \u0081";
            string d = " Unicode -> \u03A6";
            string e = "Um \t (tab) e uma  \\ (barra) ";
            string Break = "------------------------------------------------------";
            string s = String.Format("Ola {0} No. {1}!", "mundo", 3);
            string f = String.Format("{0} mais {0} é igual a {1}", "Dois", "Quatro");

            Console.WriteLine(a);
            Console.WriteLine(Break);
            Console.WriteLine(b);
            Console.WriteLine(Break);
            Console.WriteLine(c);
            Console.WriteLine(Break);
            Console.WriteLine(d);
            Console.WriteLine(Break);
            Console.WriteLine(e);
            Console.WriteLine(Break);
            Console.WriteLine(s);
            Console.WriteLine(Break);
            Console.WriteLine(f);
            Console.WriteLine(Break);
            Console.WriteLine("Enter Para Fechar.");
            Console.ReadKey();

        }
    }
}
