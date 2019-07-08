using System;
/*
 * Autor: Nicolas Ramos
 * 
 * Ambiente: Visual Studio 2019 C#
 * 
 * Licença: GNU GPL 3
 * 
 */
namespace TipoDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 11;
            double b = 3;
            double c = a / b;
            double max = double.MaxValue;
            double min = double.MinValue;

            Console.WriteLine($"{a} / {b} = {c}\n\r");
            Console.WriteLine($"double pode conter valores desde {min} até {max}");
        }
    }
}
