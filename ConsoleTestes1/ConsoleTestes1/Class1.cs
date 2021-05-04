using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestes1
{
    class Class1
    {
        public void LoopWhile()
        {
            Console.WriteLine("LoopWhile()");
            Console.WriteLine("Loop com While (bem resumido) que conta de 1 a 10.");
            Console.WriteLine();

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(++i);
            }

            Console.WriteLine();
        }
    }
}
