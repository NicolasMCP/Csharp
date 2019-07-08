using System;
/*
 * Autor: Nicolas Ramos
 * 
 * Ambiente: Visual Studio 2019 C#
 * Licença: GNU GPL 3
 * 
 */

namespace SwitchCaseVogal
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra = DigitaLetra("Digite uma Letra: ");

            Console.WriteLine();

            /* No case do C# podemos ter vazio (como no exemplo abaixo)
             * com código e um break como no exemplo do case "U": ou
             * um goto case "*"; onde * seria uma das opções.
             * C# NÃO aceita como no Java código dentro de um case SEM
             * fechar com o break; correspondente.
             */

            switch(letra.ToUpper())
            {
                case "A":
                case "E":
                case "I":
                case "O":
                case "U":
                    Console.WriteLine($"A letra '{letra}' é uma VOGAL.");
                    break;
                default:
                    Console.WriteLine($"A letra '{letra}' é uma CONSOANTE.");
                    break;
            }
        }

        private static string DigitaLetra(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                string letra = Console.ReadLine();
                if (letra.Length > 1 || letra.Length < 1)
                {
                    Console.WriteLine("Letra inválida.");
                    continue;
                }
                if ((letra.ToUpper().CompareTo("A") == -1) || (letra.ToUpper().CompareTo("Z") == 1))
                {
                    Console.WriteLine("Letra inválida");
                    continue;
                }
                return letra;
            }
        }
    }
}
