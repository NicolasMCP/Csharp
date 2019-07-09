/*
 * Autor: Nicolas Ramos
 * 
 * Ambiente: Visual Studio 2019 C#
 * 
 * Licença: GNU GPL 3
 * 
 */
using System;

namespace oFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            for(int i=10; i>0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}
