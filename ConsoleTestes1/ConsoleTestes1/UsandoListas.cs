using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestes1
{
    class UsandoListas
    {
        public static void ListaNomes()
        {
            Console.WriteLine("ListaNomes()");
            Console.WriteLine("Iniciando com listas no C#");
            Console.WriteLine();

            var nomes = new List<string> { "Nícolas Ramos", "Juan Sánchez", "Rosendo Ramos"};
            foreach (string nome in nomes)
            {
                Console.WriteLine($"Olá {nome}!");
            }
            Console.WriteLine();
            // a mesma coisa com um for em MAIÚSCULAS para diferenciar...
            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine($"Olá {nomes[i].ToUpper()}!");
            }

            Console.WriteLine();

            nomes.Add("Etelvina Sánchez");
            nomes.Add("Onorina Ramos");

            foreach (string nome in nomes)
            {
                Console.Write($"{nome}   ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"nomes[0] = {nomes[0]}");
            Console.WriteLine();

            nomes.Remove("Nícolas Ramos");

            foreach (string nome in nomes)
            {
                Console.Write($"{nome}   ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"nomes[0] = {nomes[0]}");
            Console.WriteLine();

            nomes.Add("Nícolas Ramos");

            nomes.Sort();

            Console.WriteLine();
            Console.WriteLine("Em ordem alfabetica");
            Console.WriteLine();

            foreach (string nome in nomes)
            {
                Console.Write($"{nome}   ");
            }
            
            Console.WriteLine();
        }
    }
}
