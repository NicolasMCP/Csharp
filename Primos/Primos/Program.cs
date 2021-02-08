/*
 * Autor: Nicolas Ramos
 * 
 * Ambiente: Visual Studio 2019 C#
 * 
 * Licença: GNU GPL 3
 * 
 */
using System;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intervalo de números PRIMOS\n\r");
            long ini = LerLong("Inicial: ");
            long fim = LerLong("Final  : ");

            Auxiliar a = new Auxiliar();
            a.Primos(ini, fim);

            Console.WriteLine("\nNúmeros Primos Resultantes:\n");

            a.Imprime();
            
            Console.WriteLine();
        }

        private static long LerLong(string msg)
        {
            Console.Write(msg);
            return Convert.ToInt64(Console.ReadLine());
        }
    }
}
