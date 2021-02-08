/*
 * Autor: Nicolas Ramos
 * 
 * Ambiente: Visual Studio 2019 C#
 * 
 * Licença: GNU GPL 3
 * 
 */
using System;

namespace ConteudoChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo = "Simbolo";
            char letra;
            while (true)
            {
                Console.Write("Digite um caracter: ");
                string s = Console.ReadLine();
                if (s.Length == 1)
                {
                    letra = Convert.ToChar(s);
                    break;
                }
            }

            if ((letra >= '0') && (letra <= '9')) tipo = "Digito";
            if ((letra >= 'a') && (letra <= 'z')) tipo = "Letra";
            if ((letra >= 'A') && (letra <= 'Z')) tipo = "Letra";
            if (letra == ' ') tipo = "Espaço";

            Console.WriteLine($"Você digitou um caracter do tipo {tipo}");
        }
    }
}
