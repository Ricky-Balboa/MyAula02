using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.MaxValue;
            int b = Int32.MinValue;
            int c = Int16.MaxValue;
            int d = Int16.MinValue;
            long e = long.MaxValue;
            long f = long.MinValue;
            ulong g = ulong.MaxValue;
            ulong h = ulong.MinValue;
            double i = double.MaxValue;
            double j = double.MinValue;
            short k = short.MaxValue;
            short l = short.MinValue;
            double m = double.PositiveInfinity;
            float n = float.NegativeInfinity;
            double o = m / m;
            string s = "-----------------------------------------------";

            Console.WriteLine("int32 Maximo " + a);
            Console.WriteLine(s);
            Console.WriteLine("int32 Minimo " + b);
            Console.WriteLine(s);
            Console.WriteLine("int16 Maximo " + c);
            Console.WriteLine(s);
            Console.WriteLine("int16 Minimo " + d);
            Console.WriteLine(s);
            Console.WriteLine("long Maximo " + e);
            Console.WriteLine(s);
            Console.WriteLine("long Minimo " + f);
            Console.WriteLine(s);
            Console.WriteLine("ulong Maximo " + g);
            Console.WriteLine(s);
            Console.WriteLine("ulong Minimo " + h);
            Console.WriteLine(s);
            Console.WriteLine("double Maximo " + i);
            Console.WriteLine(s);
            Console.WriteLine("double Minimo " + j);
            Console.WriteLine(s);
            Console.WriteLine("short Maximo " + k);
            Console.WriteLine(s);
            Console.WriteLine("short Minimo " + l);
            Console.WriteLine(s);
            Console.WriteLine("Infinito " + m);
            Console.WriteLine(s);
            Console.WriteLine("Infinito Negativo " + n);
            Console.WriteLine(s);
            Console.WriteLine("Não é Numero " + o);
            Console.WriteLine();
            Console.WriteLine("Enter para Sair");
            Console.ReadKey();

        }
    }
}
