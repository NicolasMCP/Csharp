using System;
/*
 * Autor: Nicolas Ramos
 * 
 * Ambiente: Visual Studio 2019 C#
 * Licença: GNU GPL 3
 * 
 */

namespace c2._1._8OperadorCondicional2
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

            int c = (a > b) ? a : b;

            Console.WriteLine($"\n\ra = {a}\n\rb = {b}\n\r\n\rO maior valor é {c}");
        }
    }
}
