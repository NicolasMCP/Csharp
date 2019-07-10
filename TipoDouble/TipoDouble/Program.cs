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
            /* No código usamos '.' como separador decimal, ao digita usamos ','
             * (caso estejamos em países que usam esse separador decimal) */
            double a = 11.4;
            double b = 3.6;
            double c = a / b;
            double max = double.MaxValue;
            double min = double.MinValue;

            Console.WriteLine($"{a} / {b} = {c}\n\r");
            Console.WriteLine($"double pode conter valores desde {min} até {max}");

            Console.WriteLine();

            Console.Write("Digite um número real diferente de 0: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite outro número real diferente de 0: ");
            b = Convert.ToDouble(Console.ReadLine());

            c = a / b;
            Console.WriteLine($"{a} / {b} = {c}\n\r");

        }
    }
}
