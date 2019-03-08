using System;
using System.Text;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Insira uma Altura");//Pedir Altura 
            string a = Console.ReadLine();//Receber input 
            int A = Convert.ToInt32(a);//Converter para Inteiro o input
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Insira um Raio");//Pedir Raio
            string r = Console.ReadLine();//Receber Input
            int R = Convert.ToInt32(r);//Converter para inteiro o input
            double V = Math.PI * R * R * A;//Calcular o Volume
            double D = 2*Math.PI*R*(R+A);//Calcular a Area
            Console.WriteLine("-----------------------------------------------");
            string v = $"O Volume do Cilindro é: V = \u03C0r^2A = {V:f3}";//String do resultado
            string d = $"A Area do Cilindro é: A = 2\u03C0r(r+A) = {D:f3} ";//String do resultado
            Console.WriteLine(v);//Apresentar o resultado
            Console.WriteLine(d);//Apresentar o resultado
            Console.WriteLine();
            Console.WriteLine("Enter para sair");
            Console.ReadKey();

        }
    }
}
