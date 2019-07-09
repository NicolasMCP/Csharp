using System;

namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=10)
            {
                Console.Write((i++) + " ");
            }
            Console.WriteLine();

            i--;

            while(i>0)
            {
                Console.Write((i--) + " ");
            }
            Console.WriteLine();

            i++;

            do
            {
                Console.Write((i++) + " ");
            } while (i <= 10);
            Console.WriteLine();

            i--;

            do
            {
                Console.Write((i--) + " ");
            } while (i > 0);
            Console.WriteLine();

            /* Diferença entre while e do while */
            i = 1;

            Console.WriteLine("While passa ");
            /* Primeiro comprova a condição, depois se for satizfeita executa o código */
            while(i > 1)
            {
                Console.WriteLine(i++);
                if (i > 3) break;
            }

            Console.Write("do While passa ");
            /* Executa o código primeiro e depóis comprova a condição, se for satizfeita volta a executar */
            do
            {
                Console.Write((i++) + " ");
                if (i > 3) break;
            } while (i > 1);

            Console.WriteLine();

        }
    }
}
