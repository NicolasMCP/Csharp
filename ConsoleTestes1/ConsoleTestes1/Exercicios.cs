using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestes1
{
    class Exercicios
    {
        public static void FibonacciAte(int limite)
        {
            var fibonacci = new List<int> { 1 };
            int ultimo;
            int penultimo;
            int proximo = 1;

            while (proximo <= limite)
            {
                fibonacci.Add(proximo);

                ultimo = fibonacci[fibonacci.Count - 1];
                penultimo = fibonacci[fibonacci.Count - 2];
                proximo = ultimo + penultimo;
            }

            ImprimeLista(fibonacci,
                "FibonacciAte(200)",
                "Cria a sequencia de fibonacci até o número limite");

        }
        static void ImprimeLista(List<int> fibonacci, string msg, string msg2)
        {
            Console.WriteLine(msg);
            Console.WriteLine(msg2);

            bool primeiro = true;

            Console.WriteLine();

            foreach (int item in fibonacci)
            {
                if (primeiro)
                    primeiro = false;
                else
                    Console.Write(", ");

                Console.Write(item);
            }
            Console.WriteLine();
        }

        public static void FibonacciSequenciaCom(int tamanho)
        {
            var fibonacci = new List<int> { 1, 1 };

            while (fibonacci.Count < tamanho)
            {
                var ultimo = fibonacci[fibonacci.Count - 1];
                var penultimo = fibonacci[fibonacci.Count - 2];
                fibonacci.Add(ultimo + penultimo);
            }

            ImprimeLista(fibonacci,
                "FibonacciSequenciaCom(20)",
                "Cria a sequencia de fibonacci do tamanho passado");
        }
    }
}
