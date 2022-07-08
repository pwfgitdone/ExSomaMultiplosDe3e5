using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número natural: ");
            int limite = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i <= limite; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine("Soma de todos os números naturais de 0 até o número informado, múltiplos de 3 ou 5: " + soma);
        }
    }
}
