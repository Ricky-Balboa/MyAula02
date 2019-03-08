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
            Console.WriteLine(a);
            Console.WriteLine("----------------------");
            Console.WriteLine(b);
            Console.WriteLine("----------------------");
            Console.WriteLine(c);
            Console.WriteLine("----------------------");
            Console.WriteLine(d);
            Console.WriteLine("----------------------");
            Console.WriteLine(e);
            Console.WriteLine("----------------------");
            Console.WriteLine(f);
            Console.WriteLine("----------------------");
            Console.WriteLine(g);
            Console.WriteLine("----------------------");
            Console.WriteLine(h);
            Console.WriteLine("----------------------");
            Console.WriteLine(i);
            Console.WriteLine("----------------------");
            Console.WriteLine(j);
            Console.WriteLine("----------------------");
            Console.WriteLine(k);
            Console.WriteLine("----------------------");
            Console.WriteLine(l);
            Console.WriteLine();
            Console.WriteLine("Enter para Sair");
            Console.ReadKey();

        }
    }
}
