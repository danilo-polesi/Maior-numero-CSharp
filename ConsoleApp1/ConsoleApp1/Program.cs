using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n1, n2, n3;

            Console.Write("Digite o 1º n.: ");
            n1 = (Console.Read());
            Console.Write("Digite o 2º n.: ");
            n2 = (Console.Read());
            Console.Write("Digite o 3º n.: ");
            n3 = (Console.Read());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("O maior número é: " + n1);
            }

            else if (n1 > n2 && n1 < n3)
            {

            }

            else if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine("O menor número é: " + n1);
            }

            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("O maior número é: " + n2);
            }

            else if (n2 > n1 && n2 < n3)
            {

            }

            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine("O menor numero é: " + n2);
            }

            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("O maior número é: " + n3);
            }

            else if (n3 > n1 && n3 < n2)
            {

            }

            else if (n3 < n1 && n3 < n2)
            {
                Console.WriteLine("O menor numero é: " + n3);
            }

            Console.ReadKey();
        }
    }
}
