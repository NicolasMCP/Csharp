/*
 * Autor: Nicolas Ramos
 * 
 * Ambiente: Visual Studio 2019 C#
 * 
 * Licença: GNU GPL 3
 * 
 */
using System;

namespace OperadorCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(Somente use valores numéricos inteiros.)\n\r");
            Console.Write("Digite o valor de 'a': ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de 'b': ");
            int b = Convert.ToInt32(Console.ReadLine());

            string str = (a > b) ? "'a' É Maior que 'b'" : (a < b) ? "'b' É Maior que 'a'" : "'a' E 'b' são Iguais.";

            Console.WriteLine($"\n\ra = {a}\n\rb = {b}\n\r\n\r" + str);
        }
    }
}
