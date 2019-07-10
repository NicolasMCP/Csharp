/*
 * Autor: Nicolas Ramos
 * 
 * Ambiente: Visual Studio 2019 C#
 * 
 * Licença: GNU GPL 3
 * 
 */
using System;

namespace mmc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Digite um número (inteiro): ");
            long num = Convert.ToInt64(Console.ReadLine());
            long x = num;
            long i;

            if ((x == 1) || (x == 2))
            {
                Console.WriteLine($"{x}");
                goto fim;
            }
            while (x > 1)
            {
                for (i = 2; (i * i) <= x; i++)
                {
                    if ((x % i) == 0)
                    {
                        if (x == i)
                            Console.Write($"{i}");
                        else
                            Console.Write($"{i}.");
                        x /= i;
                        break;
                    }
                }
                if ((i * i) > x)
                {
                    Console.Write($"{x}");
                    break;
                }
                if (x < 2) break;
            }
        fim:
            Console.WriteLine();
        }
    }
}
