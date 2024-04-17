using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, menor, i = 0, Q = 0, numero = 0;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("Deseja informar quantos numeros?: ");
            Q = Convert.ToInt32(Console.ReadLine());

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Informe o 1º número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            maior = numero;
            menor = numero;
            i = 1;

            for (i = 2; i <= Q; i++){
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Informe o "+i+"º número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < menor) { menor = numero; }
                if (numero > maior) { maior = numero; }
             }
            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
            Console.ReadKey();

        }
    }
}
