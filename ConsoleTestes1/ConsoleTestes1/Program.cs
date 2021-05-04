using System;

namespace ConsoleTestes1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicios.FibonacciSequenciaCom(20);

            Pausa.PrecionarUmaTecla("para ir a FibonacciAte(200)");
            
            Exercicios.FibonacciAte(200);
            
            Pausa.PrecionarUmaTecla("para ir a ListaNomes()");

            UsandoListas.ListaNomes();
            
            Pausa.PrecionarUmaTecla("para ir a Print1to20mult3()");            
            
            
            Print1to20.Print1to20mult3();

            Pausa.PrecionarUmaTecla("para ir a Soma1to20");
            
            SomaInt1to20 soma = new SomaInt1to20();
            soma.Soma1to20();

            Pausa.PrecionarUmaTecla("para ir a LoopWhile()");
            
            
            Class1 class1 = new Class1();
            class1.LoopWhile();

            Pausa.PrecionarUmaTecla("para voltar ao Main()");

            
            Console.WriteLine("Trabalhando com Strings");
            Console.WriteLine();

            string nome1 = "Alejandra Sanchez";
            string nome2 = "Lujan Ramos";
            string nome3 = "Macarena Olagaray Ramos";

            Console.WriteLine($"As primas {nome1}, {nome2} e {nome3} não moram no Brasil.");

            Console.WriteLine($"O tamanho do nome '{nome1}' é de {nome1.Length} caracteres");
            Console.WriteLine($"O tamanho do nome '{nome2}' é de {nome2.Length} caracteres");
            Console.WriteLine($"O tamanho do nome '{nome3}' é de {nome3.Length} caracteres");

            string s = "          Olá Mundo!     ";
            Console.WriteLine();

            string inicioS = s.TrimStart();
            string fimS = s.TrimEnd();
            string ambosS = s.Trim();

            Console.WriteLine($"[{s}]");
            Console.WriteLine($"[{inicioS}]");
            Console.WriteLine($"[{fimS}]");
            Console.WriteLine($"[{ambosS}]");

            Console.WriteLine();

            Console.WriteLine($"{ambosS.ToLower()}");
            Console.WriteLine($"{ambosS.ToUpper()}");

            Console.WriteLine();

            Console.WriteLine($"Na realidade a variável 'ambosS' continua contendo '{ambosS}',");
            Console.WriteLine("nem as maíusculas nem as minúsculas foram modificadas.");

            Console.WriteLine();

            string cancao = "Você diz adéus eu digo olá.";

            Console.WriteLine($"a canção é: {cancao}");

            Console.WriteLine();

            Console.WriteLine($"ver se a canção comtem 'adéus' --> {cancao.Contains("adéus")}");
            Console.WriteLine($"ver se a canção comtem 'adié' --> {cancao.Contains("adié")}");
            Console.WriteLine($"ver se a canção começa com 'adéus' --> {cancao.StartsWith("adéus")}");
            Console.WriteLine($"ver se a canção começa com 'Você' --> {cancao.StartsWith("Você")}");

            Pausa.PrecionarUmaTecla("para finalizar o Program().");

       }
    }
}
