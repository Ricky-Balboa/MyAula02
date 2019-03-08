using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 0.12345;//Variaveis Ex 3
            int ii = 18;//Variaveis Ex 3

            int x = 2;//Variaveis
            int y = 5;//Variaveis
            string a = " Isto é uma string ";//Exercicio 1 
            string b = @" Isto é uma string verbatim/literal";// Exercicio 1
            string c = " Unicode -> \u0081";//Exercicio 1
            string d = " Unicode -> \u03A6";//Exercicio 1
            string e = " Um \t (tab) e uma  \\ (barra) ";//Exercicio 1 
            string Break = "|------------------------------------------------------|";//Intervalo 
            string s = String.Format(" Ola {0} No. {1}!", "mundo", 3);//Exercicio 2 
            string f = String.Format(" {0} mais {0} é igual a {1}", "Dois", "Quatro");//Exercicio 2 
            string g = " sou" + "uma string" + " concatenada ";//Exercicio 2 
            g += "(sou sim senhor)";//texto do final da string g Exercicio2
            string h = $" {x} mais {y} é igual {x+y} feito por interpolação";//Exercicio 2
           

            Console.WriteLine(a);//
            Console.WriteLine(Break);
            Console.WriteLine(b);//
            Console.WriteLine(Break);
            Console.WriteLine(c);//
            Console.WriteLine(Break);
            Console.WriteLine(d);//
            Console.WriteLine(Break);
            Console.WriteLine(e);//
            Console.WriteLine(Break);
            Console.WriteLine(s);//
            Console.WriteLine(Break);
            Console.WriteLine(f);//
            Console.WriteLine(Break);
            Console.WriteLine(g);//
            Console.WriteLine(Break);
            Console.WriteLine(h);//
            Console.WriteLine(Break);
            Console.WriteLine(@" Sou mais uma string autista em verbatim :D");//Exercicio 2
            Console.WriteLine(Break);
            Console.WriteLine($" Exercicio 3 -> {xx:f2}");//Exercicio 3
            Console.WriteLine(Break);
            Console.WriteLine($" Exercicio 3 -> {xx:p1}");//Exercicio 3 
            Console.WriteLine(Break);
            Console.WriteLine($" Exercicio 3 -> {ii:x}");//Exercicio 3 
            Console.WriteLine(Break);
            Console.WriteLine($" Exercicio 3 -> {ii:c}");//Exercicio 3 
            Console.WriteLine(Break);
            Console.WriteLine(" Enter Para Fechar!");
            Console.ReadKey();

        }
    }
}
