using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 0.12345;
            int ii = 18;

            int x = 2;
            int y = 5;
            string a = " Isto é uma string ";
            string b = @" Isto é uma string verbatim/literal";
            string c = " Unicode -> \u0081";
            string d = " Unicode -> \u03A6";
            string e = " Um \t (tab) e uma  \\ (barra) ";
            string Break = "|------------------------------------------------------|";
            string s = String.Format(" Ola {0} No. {1}!", "mundo", 3);
            string f = String.Format(" {0} mais {0} é igual a {1}", "Dois", "Quatro");
            string g = " sou" + "uma string" + " concatenada ";
            g += "(sou sim senhor)";//texto do final da string g
            string h = $" {x} mais {y} é igual {x+y} feito por interpolação";
           

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
            Console.WriteLine(g);
            Console.WriteLine(Break);
            Console.WriteLine(h);
            Console.WriteLine(Break);
            Console.WriteLine(@" Sou mais uma string autista em verbatim :D");
            Console.WriteLine(Break);
            Console.WriteLine($" Exercicio 3 -> {xx:f2}");
            Console.WriteLine(Break);
            Console.WriteLine($" Exercicio 3 -> {xx:p1}");
            Console.WriteLine(Break);
            Console.WriteLine($" Exercicio 3 -> {ii:x}");
            Console.WriteLine(Break);
            Console.WriteLine($" Exercicio 3 -> {ii:c}");
            Console.WriteLine(Break);
            Console.WriteLine(" Enter Para Fechar!");
            Console.ReadKey();

        }
    }
}
