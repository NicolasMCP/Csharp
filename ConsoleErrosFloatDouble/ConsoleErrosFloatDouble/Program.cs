using System;
/*
 * Autor: Nicolas Ramos
 * 
 * Ambiente: Visual Studio 2019 C#
 * 
 * Licença: GNU GPL 3
 * 
 */
namespace ConsoleErrosFloatDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("float no C#");

            float c = 1.1f;
            float d = 1.2f;
            float re = c + d;

            Console.WriteLine("c = " + c.ToString("e10"));
            Console.WriteLine("d = " + d.ToString("e10"));
            Console.WriteLine("resultado c + d = " + re.ToString("e10"));

            Console.WriteLine();

            Console.WriteLine("double no C#");

            double a = 1.1d;
            double b = 1.2d;
            double r = a + b;

            Console.WriteLine("a = " + a.ToString("e20"));
            Console.WriteLine("b = " + b.ToString("e20"));
            Console.WriteLine("resultado a + b = " + r.ToString("e20"));

            Console.WriteLine();

            Console.WriteLine("Decimal no C#");

            Decimal x = 1.1m;
            Decimal y = 1.2m;

            Decimal resultado = x + y;

            Console.WriteLine("x = " + x.ToString("e20"));
            Console.WriteLine("y = " + y.ToString("e20"));

            Console.WriteLine("resultado x + y = " + resultado.ToString("e20"));

            Console.WriteLine();

            Console.WriteLine("loop com float de 1.1f até 1.5f, incrementando 0.1f");

            int cont = 1;
            for (float i = 1.1f; i <= 1.5f; i += 0.1f)
            {
                Console.WriteLine((cont++) + "  valor = " + i.ToString("e16"));
            }

            Console.WriteLine();

            Console.WriteLine("loop com double de 1.1d até 1.5d, incrementando 0.1d");

            cont = 1;
            for (double i = 1.1d; i <= 1.5d; i += 0.1d)
            {
                Console.WriteLine((cont++) + "  valor = " + i.ToString("e16"));
            }

            Console.WriteLine();
            Console.WriteLine("loop com Decimal de 1.1m até 1.5m, incrementando 0.1m");
            Console.WriteLine();
            Console.WriteLine("Por causa do erro de precissão tanto 'float' como 'double' não fazem 5 loops,");
            Console.WriteLine("o que não acontece com 'Decimal'");
            Console.WriteLine();

            Console.WriteLine("Decimal no C#");

            cont = 1;
            for (Decimal i = 1.1m; i <= 1.5m; i += 0.1m)
            {
                Console.WriteLine((cont++) + "  valor = " + i.ToString("e16"));
            }


            Console.ReadKey();
        }
    }
}
