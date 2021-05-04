using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestes1
{
    class Print1to20
    {
        public static void Print1to20mult3()
        {
            Console.WriteLine("Print1to20mult3()");
            Console.WriteLine("Imprime os números entre 1 e 20 multiplos de 3 e a sua soma");
            Console.WriteLine();

            int soma = 0;
            bool primeiro = true;

            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    if (primeiro)
                        primeiro = false;
                    else
                        Console.Write(" + ");

                    Console.Write(i);
                    soma += i;
                }
            }
            Console.Write($" = {soma}");

            Console.WriteLine();
        }
    }
}
