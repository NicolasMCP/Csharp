/*
 * Autor: Nicolas Ramos
 * 
 * Ambiente: Visual Studio 2019 C#
 * 
 * Licença: GNU GPL 3
 * 
 */
using System;

namespace SubStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //                    11111111112222222222333333333344444444445555555555666666666677777777778
            //          012345678901234567890123456789012345678901234567890123456789012345678901234567890
            string str = "Isto é uma string bastante comprida, vamos ver o que conseguimos descobrir disso.";
            Console.WriteLine($"Frase inteira (não inclui as aspas simples):\n'{str}'\n");
            Console.WriteLine(str.Substring(0, 4));
            //                          (ini,tamanho)
            Console.WriteLine(str.Substring(11, 6));
            Console.WriteLine(str.Substring(27, 8));
            //                           ini --> se tamanho for omitido vai até o final
            Console.WriteLine(str.Substring(27));

            // buscando: palabra ('descobrir')
            string palabra = "descobrir";
            string result;
            int pos = str.IndexOf(palabra);
            if (pos >= 0)
            {
                result = $"A palabra buscada '{palabra}' encontrasse na possição {pos}";
            }
            else
            {
                result = $"A palabra buscada '{palabra}' não se encontra na frase:\n'{str}'";
            }
            Console.WriteLine(result);
            Console.WriteLine();

            // conta a quantia de: palabraBuscada
            Busca(str, "Isto");
            Busca(str, "o");
            Busca(str, "a");
            Busca(str, ".");
            Busca(str, "st");
            Busca(str, "c");
            Busca(str, "s");
            Busca(str, "ri");
            Busca(str, "e");
            Busca(str, "é");
            Busca(str, "i");
            Busca(str, "I");
        }
        static void Busca(string str, string palabraBuscada)
        {
            int contador = 0;
            int pos = 0;
            while (pos >= 0)
            {
                pos = str.IndexOf(palabraBuscada, pos);
                if (pos >= 0)
                {
                    contador++;
                    pos++;
                }
            }
            Console.WriteLine($"Quantidade da palabra/letra/caracter: '{palabraBuscada}' na frase = {contador}");

        }
    }
}
